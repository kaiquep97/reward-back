﻿using System;

namespace Rewards.Core.Entities
{
    public class Points
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int Pontuation { get; set; }
        public DateTime CreateDateTime { get; set; }
    }


}
