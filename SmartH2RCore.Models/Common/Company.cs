using SmartH2RCore.Models.Base;
using SmartH2RCore.Models.Employee;
using SmartH2RCore.Models.Identity;

using System;
using System.Collections.Generic;

namespace SmartH2RCore.Models.Common
{
    public class Company : ArchivableEntity<int>
    {
        public string CompanyName { get; set; }
        public string CompanyType { get; set; }
        public DateTime? EstablishDate { get; set; }
        public string PanNo { get; set; }
        public string TinNo { get; set; }
        public string RegistrationNo { get; set; }
        public string TanNo { get; set; }
        public string TdsCircle { get; set; }
        public string PfTrust { get; set; }
        public string Url { get; set; }
        public string Logo { get; set; }
        public string CorporateAddress1 { get; set; }
        public string CorporateAddress2 { get; set; }
        public int CorporateCityId { get; set; }
        public int CorporateStateId { get; set; }
        public int CorporateCountryId { get; set; }
        public string CorporateZip { get; set; }
        public string CorporatePhone { get; set; }
        public string CorrespondanceAddress1 { get; set; }
        public string CorrespondanceAddress2 { get; set; }
        public int CorrespondanceCityId { get; set; }
        public int CorrespondanceStateId { get; set; }
        public int CorrespondanceCountryId { get; set; }
        public string CorrespondanceZip { get; set; }
        public string CorrespondancePhone { get; set; }
        public string CompanyEngaged { get; set; }
        public string EpfNo { get; set; }
        public string EpfDbfFileCode { get; set; }
        public string EpfDbfExt { get; set; }
        public string EsiNo { get; set; }
        public string EsiLocalNo { get; set; }
        public string ResponsiblePerson { get; set; }
        public string NatureOfBusiness { get; set; }
        public string EPFEmployerCode { get; set; }
        public string SubEPFEmployerCode { get; set; }
        public string ESIEmployerCode { get; set; }
        public string SubESIEmployerCode { get; set; }

        public int OwnerId { get; set; }
        public User User { get; set; }

        public virtual ICollection<Branch> Branch { get; set; }

        public virtual ICollection<ApproverInformation> ApproverInformation { get; set; }
        public virtual ICollection<ChildrenDetails> ChildrenDetails { get; set; }
        public virtual ICollection<ContactList> ContactList { get; set; }
        public virtual ICollection<DocumentDetails> DocumentDetails { get; set; }
        public virtual ICollection<EducationalQualification> EducationalQualification { get; set; }
        public virtual ICollection<EmergencyContactDetails> EmergencyContactDetails { get; set; }
        public virtual ICollection<ExperienceDetails> ExperienceDetails { get; set; }
        public virtual ICollection<JobDetails> JobDetails { get; set; }
        public virtual ICollection<PersonalDetails> PersonalDetails { get; set; }
        public virtual ICollection<ProfessionalQualification> ProfessionalQualification { get; set; }
        public virtual ICollection<TrainingDetails> TrainingDetails { get; set; }

        public Company()
        {

        }

    }
}
