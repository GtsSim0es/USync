﻿using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USync.Domain.Common
{
    public abstract class Entity(long id) : Notifiable<Notification>
    {
        public long Id { get; set; } = id;

        public long LastUserAlteration { get; set; }

        public DateTime LastUserAlterationDateTime { get; set; }

        public long CreatedUserId { get; set; }

        public DateTime CreatedDateTime { get; set; }
    }
}