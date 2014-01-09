﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlobusLinkedinLib.App.Core
{
    public class Global
    {
        public static string GetNetworkUserUpdates = "http://api.linkedin.com/v1/people/id=";
        public static string GetNetworkUpdates = "http://api.linkedin.com/v1/people/~/network/updates";
        public static string GetJobSearchTitle = "http://api.linkedin.com/v1/job-search?job-title=";
        public static string GetJobSearchKeyword = "http://api.linkedin.com/v1/job-search?keywords=";
        public static string GetUserProfile = "http://api.linkedin.com/v1/people/~:(id,first-name,last-name,headline,picture_url,educations,location,date_of_birth)";
        public static string StatusUpdate = "http://api.linkedin.com/v1/people/~/current-status";
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static string GetUserProfileUrl = "http://api.linkedin.com/v1/people/~:(id,first-name,headline,last-name,industry,site-standard-profile-request,api-standard-profile-request,member-url-resources,picture-url,current-status,summary,positions,main-address,location,distance,specialties,proposal-comments,associations,honors,interests,educations,phone-numbers,im-accounts,twitter-accounts,date-of-birth,email-address)";
        public static string GetPeopleSearchUrl = "http://api.linkedin.com/v1/people-search?keyword=";
        public static string GetPeopleConnectionUrl = "http://api.linkedin.com/v1/people/~/connections";

    }
}
