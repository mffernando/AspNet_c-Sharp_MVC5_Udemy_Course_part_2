using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Routes.Models
{
    public class Notice
    {
        public int NoticeId { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public IEnumerable<Notice> AllNotices()
        {
            var return = new Collection<Notice>
            {
                new Notice
                {
                    NoticeId=1,
                    Category="Soccer",
                    Title="Soccer game",
                    Content="Notice about soccer games!",
                    Date=new Datetime(2018,3,5),
                },
                new Notice
                {
                    NoticeId=2,
                    Category="Basketball",
                    Title="Basketball game",
                    Content="Notice about Basktetball games!",
                    Date=new Datetime(2018,3,5),
                },
                new Notice
                {
                    NoticeId=3,
                    Category="Volleyball",
                    Title="Volleyball game",
                    Content="Notice about Volleyball games!",
                    Date=new Datetime(2018,3,5),
                },
            }
        }
    }
}