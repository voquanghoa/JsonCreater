using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace JsonCreater
{
	[DataContract]
	public class DataItem
	{
		[DataMember(Name = "fileName", IsRequired = true)]
		public string FileName
		{
			get; set;
		}

		[DataMember(Name = "display", IsRequired = true)]
		public string Display
		{
			get; set;
		}

		[DataMember(Name = "children", IsRequired = false)]
		public List<DataItem> Children
		{
			get; set;
		}
	}

	[DataContract]
	public class Question
	{
		[DataMember(Name = "questionTitle", IsRequired = true)]
		public string QuestionTitle
		{
			get; set;
		}

		[DataMember(Name = "answers", IsRequired = true)]
		public List<string> Answers
		{
			get; set;
		}

		[DataMember(Name = "correctAnswer", IsRequired = true)]
		public int CorrectAnswer
		{
			get; set;
		}
	}

	[DataContract]
	public class ListenContent : List<Question>
	{
		
	}
}

