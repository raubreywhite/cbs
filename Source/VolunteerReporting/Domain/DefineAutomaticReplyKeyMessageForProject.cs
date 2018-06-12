using System;
using Concepts;
using Dolittle.Commands;

namespace Domain
{
    public class DefineAutomaticReplyKeyMessageForProject : ICommand
    {
        public HealthRiskId HealthRiskId { get; set; }
        public ProjectId ProjectId { get; set; }
        public AutomaticReplyKeyMessageType Type { get; set; }
        public string Language { get; set; }
        public string Message { get; set; }
    }
}