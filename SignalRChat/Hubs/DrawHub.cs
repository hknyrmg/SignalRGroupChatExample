﻿using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRChat.Hubs
{
    public class DrawHub : Hub
    {
        public Task Draw(int prevX, int prevY, int currentX, int currentY, string color)
        {
            return Clients.Others.SendAsync("draw", prevX, prevY, currentX, currentY, color);
        }
    }
}
