﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CrowdFun.Core.model
{
   public  class BackerReward
    {
        public int BackerId { get; set; }
        public Backer Backers { get; set; }
        public Reward Rewards { get; set; }
    }
}
