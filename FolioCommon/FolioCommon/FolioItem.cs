using System;
using System.Collections.Generic;
using System.Text;

namespace FolioCommon
{
        public enum StatusType { InDevelopment, Released }

    public class FolioItem
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Role { get; set; }
        public string? Type { get; set; }

        public string? TechStack { get; set; }
        public StatusType Status { get; set; }
        public Uri? Link1 { get; set; }
        public Uri? Link2 { get; set; }
        public Uri? GitHub { get; set; }

        public bool IsWebsite { get; } = false;
        public bool IsSourceAvailable { get; } = false;

        public FolioItem(int id, string name, string desc, string role, string type, string techStack, StatusType status, string? link1, string? link2, string? gitHub)
        {
            this.ID = id;
            this.Name = name;
            this.Description = desc;
            this.Role = role;
            this.TechStack = techStack;
            this.Type = type;
            this.Status = status;
            if (link1 != null)
            {
                this.Link1 = new Uri(link1);
                this.IsWebsite = true;
            }
            else
            {
                this.Link1 = null;
                this.IsWebsite = false;
            }
            if (link2 != null && link2.Length>0)
            {
                this.Link2 = new Uri(link2);
                this.IsWebsite = true;
            }
            else
            {
                this.Link2 = null;
            }

            if (gitHub != null)
            {
                this.GitHub = new Uri(gitHub);
                this.IsSourceAvailable = true;
            }
            else
            {
                this.GitHub = null;
                this.IsSourceAvailable= false;
            }
        }

    }
}
