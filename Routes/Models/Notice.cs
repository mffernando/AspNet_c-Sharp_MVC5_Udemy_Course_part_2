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
            var ret = new Collection<Notice>
            {
                new Notice
                {
                    NoticeId=1,
                    Category="Sport",
                    Title="Soccer game",
                    Content="Notice about soccer games!",
                    Date=new DateTime(2018,3,5),
                },
                new Notice
                {
                    NoticeId=2,
                    Category="Sport",
                    Title="Basketball game",
                    Content="Notice about Basktetball games!",
                    Date=new DateTime(2018,3,5),
                },
                new Notice
                {
                    NoticeId=3,
                    Category="Sport",
                    Title="Volleyball game",
                    Content="Notice about Volleyball games!",
                    Date=new DateTime(2018,3,1),
                },
                new Notice
                {
                    NoticeId=4,
                    Category="Sport",
                    Title="Golf game",
                    Content="Notice about golf games!",
                    Date=new DateTime(2018,3,2),
                }
            };

            return ret;

        }
    }
}
