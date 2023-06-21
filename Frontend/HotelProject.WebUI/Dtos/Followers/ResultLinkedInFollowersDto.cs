namespace HotelProject.WebUI.Dtos.Followers
{
    public class ResultLinkedInFollowersDto
    {

            public Graph graph { get; set; }
            public Extractor extractor { get; set; }
            public string raw { get; set; }

        public class Graph
        {
            public string context { get; set; }
            public Graph2[] graph2 { get; set; }
        }

        public class Graph2
        {
            public string type { get; set; }
            public Address address { get; set; }
            public Alumniof[] alumniOf { get; set; }
            public object[] awards { get; set; }
            public Image image { get; set; }
            public object[] jobTitle { get; set; }
            public string name { get; set; }
            public string sameAs { get; set; }
            public string url { get; set; }
            public object[] memberOf { get; set; }
            public object[] worksFor { get; set; }
            public Knowslanguage[] knowsLanguage { get; set; }
            public string disambiguatingDescription { get; set; }
            public Interactionstatistic interactionStatistic { get; set; }
            public Reviewedby reviewedBy { get; set; }
        }

        public class Address
        {
            public string type { get; set; }
            public string addressLocality { get; set; }
            public string addressCountry { get; set; }
        }

        public class Image
        {
            public string type { get; set; }
            public string contentUrl { get; set; }
        }

        public class Interactionstatistic
        {
            public string type { get; set; }
            public string interactionType { get; set; }
            public string name { get; set; }
            public int userInteractionCount { get; set; }
        }

        public class Reviewedby
        {
            public string type { get; set; }
            public string name { get; set; }
        }

        public class Alumniof
        {
            public string type { get; set; }
            public string name { get; set; }
            public string url { get; set; }
            public Member member { get; set; }
        }

        public class Member
        {
            public string type { get; set; }
            public int startDate { get; set; }
            public int endDate { get; set; }
        }

        public class Knowslanguage
        {
            public string type { get; set; }
            public string name { get; set; }
        }

        public class Extractor
        {
            public Education[] education { get; set; }
            public Address1 address { get; set; }
            public Alumniof1[] alumniOf { get; set; }
            public object[] awards { get; set; }
            public Image1 image { get; set; }
            public object[] jobTitle { get; set; }
            public string name { get; set; }
            public string sameAs { get; set; }
            public string url { get; set; }
            public object[] memberOf { get; set; }
            public object[] worksFor { get; set; }
            public Knowslanguage1[] knowsLanguage { get; set; }
            public string disambiguatingDescription { get; set; }
            public Interactionstatistic1 interactionStatistic { get; set; }
        }

        public class Address1
        {
            public string type { get; set; }
            public string addressLocality { get; set; }
            public string addressCountry { get; set; }
        }

        public class Image1
        {
            public string type { get; set; }
            public string contentUrl { get; set; }
        }

        public class Interactionstatistic1
        {
            public string type { get; set; }
            public string interactionType { get; set; }
            public string name { get; set; }
            public int userInteractionCount { get; set; }
        }

        public class Education
        {
            public string name { get; set; }
            public string url { get; set; }
            public string degree { get; set; }
            public string field { get; set; }
            public object activities { get; set; }
            public string startDate { get; set; }
            public string endDate { get; set; }
        }

        public class Alumniof1
        {
            public string type { get; set; }
            public string name { get; set; }
            public string url { get; set; }
            public Member1 member { get; set; }
        }

        public class Member1
        {
            public string type { get; set; }
            public int startDate { get; set; }
            public int endDate { get; set; }
        }

        public class Knowslanguage1
        {
            public string type { get; set; }
            public string name { get; set; }
        }



    }
}
