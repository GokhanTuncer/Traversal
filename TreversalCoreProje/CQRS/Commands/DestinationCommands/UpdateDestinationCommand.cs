﻿namespace TreversalCoreProje.CQRS.Commands.DestinationCommands
{
    public class UpdateDestinationCommand
    {
        public int Destinationid { get; set; }
        public string City { get; set; }
        public string Daynight { get; set; }
        public double Price { get; set; }
    }
}
