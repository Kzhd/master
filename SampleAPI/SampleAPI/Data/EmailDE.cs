using System;

namespace SampleAPI.Data
{
    [Serializable]
    public class EmailDE
    {
      public int Id { get; set; }  
      public string[] Names { get; set; }
    }
}