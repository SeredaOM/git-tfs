﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sep.Git.Tfs.Commands;

namespace Sep.Git.Tfs.Core
{
    public class RemoteInfo
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public string Repository { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string IgnoreRegex { get; set; }
        public bool NoMetaData { get; set; }
        public IEnumerable<string> Aliases { get; set; }
        public bool Autotag { get; set; }

        public RemoteOptions RemoteOptions
        {
            get { return new RemoteOptions { IgnoreRegex = IgnoreRegex, NoMetaData = NoMetaData, Username = Username, Password = Password }; }
            set { IgnoreRegex = value.IgnoreRegex; NoMetaData = value.NoMetaData; Username = value.Username; Password = value.Password; }
        }
    }
}
