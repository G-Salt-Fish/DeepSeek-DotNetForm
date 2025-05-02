using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
	internal class DeepSeek
	{
        private const string API_URL = "https://api.deepseek.com/chat/completions";

        private bool isTalking = false;
		
		private string api_key;

		private string systemMessage;

		private bool haveTalked = false;

		public string SystemPrompt
		{
			get { return systemMessage; }
			set
			{
				if(haveTalked == false)
				{
					systemMessage = value;
					this.messages = new List<Dictionary<string, string>>() { new Dictionary<string, string>() { { "role", "system" }, { "content", systemMessage } } };
				}
				else
				{
					throw new Exception("进行对话后，不能再设置系统提示词。");
				}
			}
		}

		public bool HaveTalked
		{
			get { return haveTalked; }
		}

		public bool IsTalking
		{
			get { return isTalking; }
		}

		private List<Dictionary<string, string>> messages = new List<Dictionary<string, string>>();
		/// <summary>
		/// DeepSeek的构造函数
		/// </summary>
		/// <param name="SystemMessage">系统提示词</param>
		public DeepSeek (string Api_key,string SystemMessage="")
		{
			systemMessage = SystemMessage;
			this.messages.Add(new Dictionary<string, string>() { { "role", "system" }, { "content", SystemMessage } });
		}
		/// <summary>
		/// 重新设置API Key
		/// </summary>
		/// <param name="new_key">新的API Key</param>
		public void ChangeKey(string new_key)
		{
			api_key = new_key;
		}
		/// <summary>
		/// 获取当前的API Key
		/// </summary>
		/// <returns>API Key</returns>
		public string ShowKey()
		{
			return api_key;
		}

		
		/// <summary>
		/// 与DeepSeek进行对话
		/// </summary>
		/// <param name="input">输入给DeepSeek的文本</param>
		/// <returns></returns>
		/// <exception cref="Exception"></exception>
		public async Task<string>Talk(string input)
		{
			isTalking = true;
			haveTalked = true;
			var client = new HttpClient();

			this.messages.Add(new Dictionary<string, string>() { { "role", "user" }, { "content", input } });

			//client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
			client.DefaultRequestHeaders.Add("Accept", "application/json");
			client.DefaultRequestHeaders.Add("Authorization", $"Bearer {api_key}");

			var requestBody = new
			{
				model = "deepseek-chat",
				messages = this.messages,
				temperature = 0.7,
				max_tokens = 8192
			};

			var json = JsonConvert.SerializeObject(requestBody);
			var content = new StringContent(json, Encoding.UTF8, "application/json");

			var response = await client.PostAsync(API_URL, content);
			var responseString = await response.Content.ReadAsStringAsync();

			if (response.IsSuccessStatusCode)
			{
				var result = JsonConvert.DeserializeObject<dynamic>(responseString);
				messages.Add(new Dictionary<string, string>() { { "role", "assistant" }, { "content", result.choices[0].message.content.ToString() } });
				isTalking = false;
				return result.choices[0].message.content;
			}
			else
			{
				isTalking = false;
				throw new Exception($"Error: {response.StatusCode} - {responseString}");
				
			}
			
		}

		public void Reset()
		{
			messages.Clear();
			haveTalked = false;
			isTalking = false;
			api_key = string.Empty;
			systemMessage = string.Empty;
		}
	}
}
