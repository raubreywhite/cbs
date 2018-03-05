using System;
using System.Collections.Generic;
using Concepts;

namespace Read.StaffUsers.DataOwner
{
    public class DataOwner
    {
        //TODO: Update to the new system
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public int YearOfBirth { get; set; }
        public Sex Sex { get; set; }
        public Guid NationalSociety { get; set; }
        public Language PreferredLanguage { get; set; }
        public Location Location { get; set; }
        public List<PhoneNumber> MobilePhoneNumbers { get; set; }
        public List<Guid> AssignedNationalSocieties { get; set; }
        public string Position { get; set; }
        public string DutyStation { get; set; }
    }
}
