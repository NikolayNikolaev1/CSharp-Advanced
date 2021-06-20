using System.Collections.Generic;

namespace The_V_Logger
{
    class Vlogger
    {
        private string name;
        private HashSet<Vlogger> followers;
        private HashSet<Vlogger> following;

        public Vlogger(string name)
        {
            this.Name = name;
            this.followers = new HashSet<Vlogger>();
            this.following = new HashSet<Vlogger>();
        }

        public string Name { get => this.name; set => this.name = value; }

        public IReadOnlyCollection<Vlogger> Followers { get => this.followers; }

        public IReadOnlyCollection<Vlogger> Following { get => this.following; }

        public void addFollower(Vlogger vlogger) 
        {
            if (!vlogger.Equals(this))
            {
                this.followers.Add(vlogger);
            }
        }
        public void addFollowing(Vlogger vlogger) 
        {
            if (!vlogger.Equals(this)) {
                this.following.Add(vlogger);
            }
        } 
    }
}
