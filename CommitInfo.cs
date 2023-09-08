// ********************************************************************
// * 
// * File   : CommitInfo.cs
// * Author : Mathilda Nynäs <mathilda.nynas@gmail.com>
// *
// * Copyright (C) (2023) Centria University of Applied Sciences.
// * All rights reserved.
// *
// * Unauthorized copying of this file, via any medium is strictly
// * prohibited.
// *
// ********************************************************************

using LibGit2Sharp;

namespace Scanner
{
    public class CommitInfo
    {
        public List<string> filenames = new();
        public Signature Author { get; }
        public DateTimeOffset Date { get; }
        public string Sha { get; }

        public CommitInfo(Signature author, DateTimeOffset date, string sha)
        {
            this.Author = author;
            this.Date = date;
            this.Sha = sha;
        }

        public void AddToNameList(List<string> names)
        {
            if (names.Count == 0)
            {
                Console.WriteLine("no names here");
            }
            foreach (string name in names)
            {
                if (filenames.Contains(name))
                {
                    continue;
                }
                else
                {
                    filenames.Add(name);
                }
            }
        }
    }
}
