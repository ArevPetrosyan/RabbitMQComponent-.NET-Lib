﻿using RabbitMQComponent.Models.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQComponent.Interfaces
{
    public interface IConfigDataService
    {
        FeedConstructModel FeedConstructModel { get; }
        TargetProxyModel TargetProxyModel { get; }
    }
}
