﻿using DotNetRu.DataStore.Audit.XmlEntities;

namespace PushNotifications
{
    public class UpdateContent
    {
        public MeetupEntity[] Meetups { get; set; }

        public TalkEntity[] Talks { get; set; }

        public SpeakerEntity[] Speakers { get; set; }

        public VenueEntity[] Venues { get; set; }

        public FriendEntity[] Friends { get; set; }
    }
}
