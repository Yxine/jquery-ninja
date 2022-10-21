using Microsoft.AspNetCore.Html;

namespace jQueryNinja.Models
{

	/// <summary></summary>
	public static class NewsModel
	{

		/// <summary></summary>
		public struct NewsStruct
		{

			/// <summary></summary>
			public int Id;

			/// <summary></summary>
			public DateTime Created;

			/// <summary></summary>
			public string Title;

			/// <summary></summary>
			public string Notice;

		}

		/// <summary></summary>
		public static List<NewsStruct> News
		{
			get
			{
				var list = new List<NewsStruct>
				{
					new NewsStruct { Id = 1, Created = new DateTime(2022, 10, 21, 11, 0, 0), Title = "Новость № 1", Notice = "Анонс новости № 1" },
					new NewsStruct { Id = 2, Created = new DateTime(2022, 10, 20, 11, 0, 0), Title = "Новость № 2", Notice = "Анонс новости № 2" },
					new NewsStruct { Id = 3, Created = new DateTime(2022, 10, 19, 11, 0, 0), Title = "Новость № 3", Notice = "Анонс новости № 3" },
					new NewsStruct { Id = 4, Created = new DateTime(2022, 10, 18, 11, 0, 0), Title = "Новость № 4", Notice = "Анонс новости № 4" },
					new NewsStruct { Id = 5, Created = new DateTime(2022, 10, 17, 11, 0, 0), Title = "Новость № 5", Notice = "Анонс новости № 5" },
					new NewsStruct { Id = 6, Created = new DateTime(2022, 10, 16, 11, 0, 0), Title = "Новость № 6", Notice = "Анонс новости № 6" },
					new NewsStruct { Id = 7, Created = new DateTime(2022, 10, 15, 11, 0, 0), Title = "Новость № 7", Notice = "Анонс новости № 7" },
					new NewsStruct { Id = 8, Created = new DateTime(2022, 10, 14, 11, 0, 0), Title = "Новость № 8", Notice = "Анонс новости № 8" },
					new NewsStruct { Id = 9, Created = new DateTime(2022, 10, 13, 11, 0, 0), Title = "Новость № 9", Notice = "Анонс новости № 9" },
					new NewsStruct { Id = 10, Created = new DateTime(2022, 10, 12, 11, 0, 0), Title = "Новость № 10", Notice = "Анонс новости № 10" }
				};
				return list;
			}
		}

		/// <summary></summary>
		/// <param name="news"></param>
		/// <returns></returns>
		public static string TemplateSimple(NewsStruct news)
		{
			return string.Format("<div class=\"news-item\"><div><h2>{2}</h2><span>{1}</span></div><p>{3}</p><small>#{0}</small></div>", news.Id, news.Created, news.Title, news.Notice);
		}

		/// <summary></summary>
		/// <param name="news"></param>
		/// <returns></returns>
		public static string TemplateFull(NewsStruct news)
		{
			return string.Format("<div class=\"news-item\"><div><h2>{2}</h2><span>{1}</span></div><p><strong>{3}</strong></p><p>Тело новости № {0}</p><small>#{0}</small></div>", news.Id, news.Created, news.Title, news.Notice);
		}

		/// <summary></summary>
		public static HtmlString DrawTemplate(string content)
		{
			return new HtmlString(content);
		}

	}

}
