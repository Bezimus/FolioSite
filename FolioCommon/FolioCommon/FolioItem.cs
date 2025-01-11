using System;
using System.Collections.Generic;
using System.Text;

namespace FolioCommon

    internal enum StatusType {InDevelopment,Released }

{
    internal class FolioItem
    {
        public int ID {  get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        public StatusType Status { get; set; }

    public FolioItem(int id, string name, string desc, string type, StatusType status)
    {
        this.ID = id;
        this.Name = name;
        this.Description = desc;
        this.Type = type;
        this.Status = status;

    }

    }
}
