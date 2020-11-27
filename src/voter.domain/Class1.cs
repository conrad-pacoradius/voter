using System;
using System.Collections.Generic;

namespace voter.domain
{
    public class Class1
    {
    }

    public class Government
    {

    }

    /// <summary>
    /// A polity is an identifiable political entity—any group of people who have a collective identity,
    /// who are organized by some form of institutionalized social relations, and have a capacity to
    /// mobilize resources. It is useful then to think of a polity as a political community.
    /// </summary>
    public class Polity
    {
        public string Name { get; set; }

        public Polity(string name, Constitution constitution)
        {
            Name = name;
        }
    }

    public class Constitution
    {
        public string Preamble { get; set; }
        public List<ConstitutionArticle> Articles { get; set; }
        public List<ConstitutionAmendment> Amendments { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime FirstAmendentAt { get; set; }
        public DateTime LastAmendentAt { get; set; }
    }

    public class ConstitutionAmendment
    {
        public string Name { get; set; }
        public List<ConstitutionSection> Sections { get; set; }
    }

    public class ConstitutionArticle
    {
        public string Name { get; set; }
        public List<ConstitutionSection> Sections { get; set; }
    }

    public class ConstitutionSection
    {
        public string Name { get; set; }
        public string Text { get; set; }
    }

    public class Legislature
    {

    }

    /// <summary>
    /// A sovereign state in international law is a political entity that is represented by one centralized government that has sovereignty over a geographic area.
    /// </summary>
    public class Country
    {
        public string Name { get; set; }

        public Country(string name)
        {
            Name = name;
        }
    }

    public class Person
    {
        public string Name { get; set;}
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person(string name, string lastName, DateTime dateOfBirth )
        {
            Name = name;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
    }

    public class Citizen
    {

    }

    public class Constituent
    {

    }

    public class Voter
    {
        public string Name { get; set; }
    }

    public class Election
    {
        public DateTime VotingStartDate { get; set; }
        public DateTime VotingEndDate { get; set; }

        public DateTime VoterRegistrationStartDate { get; set; }
        public DateTime VoterRegistrationEndDate { get; set; }

        public List<Voter> Voters { get; }
        public List<Ballot> Votes { get; }
        public List<Candidate> Candidates { get; set; }


        public Election()
        {

        }

        public void RegisterVoter(Voter voter)
        {

        }
    }

    public class ElectionPeriod
    {

    }

    public class Referendum
    {

    }

    public class Initiative
    {
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }

    public enum ElectionType
    {
        Plurality,
        Majority,
        Proportional
    }

    public class Ballot
    {

    }

    public class VoterRegistration
    {

    }

    public class EleectionVoterRegistrationRules
    {

    }

    public class PoliticalParty
    {

    }

    public class Candidate
    {

    }

    public class ElectionCandidateRegistrationRules
    {

    }


    public class CandidateRegistration
    {

    }

}
