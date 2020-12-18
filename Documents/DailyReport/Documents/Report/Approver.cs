namespace Documents.Reports
{
    using System;

    public class Approver
    {
        private string post;
        private string name;

        public Approver()
        {
            this.post = string.Empty;
            this.name = string.Empty;
        }

        public Approver(Approver appr)
        {
            this.name = appr.Name;
            this.post = appr.Post;
        }

        public Approver(string Name, string Post)
        {
            this.name = Name;
            this.post = Post;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Post
        {
            get
            {
                return this.post;
            }
            set
            {
                this.post = value;
            }
        }
    }
}

