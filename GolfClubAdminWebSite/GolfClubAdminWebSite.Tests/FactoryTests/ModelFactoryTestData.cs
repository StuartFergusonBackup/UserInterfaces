﻿namespace GolfClubAdminWebSite.Tests.FactoryTests
{
    using System;
    using System.Collections.Generic;
    using Areas.Account.Models;
    using Areas.GolfClubAdministrator.Models;
    using ManagementAPI.Service.DataTransferObjects.Responses;

    public class ModelFactoryTestData
    {
        public static String ConfirmPassword = "123456";
        public static String Password = "123456";
        public static String Email = "testclubadmin@golfclub.co.uk";
        public static String FirstName = "FirstName";
        public static String LastName = "LastName";
        public static String TelephoneNumber = "0123456789";

        public static Guid ClubId = Guid.Parse("E7ED031E-EEAB-4EE6-8D52-A6ACE1F39B88");
        public static String ClubName = "Test Club";
        public static String AddressLine1 = "Address Line 1";
        public static String AddressLine2 = "Address Line 2";
        public static String Region = "Region";
        public static String Website = "www.golfclub.co.uk";
        public static String ClubTelephoneNumber = "0123456789";
        public static String EmailAddress = "testclub@golfclub.co.uk";
        public static String PostalCode = "TE57 1NG";
        public static String Town = "Town";
        
        public static RegisterClubAdministratorViewModel GetRegisterClubAdministratorViewModel()
        {
            return new RegisterClubAdministratorViewModel
                   {
                       ConfirmPassword = ModelFactoryTestData.ConfirmPassword,
                       Email = ModelFactoryTestData.Email,
                       FirstName = ModelFactoryTestData.FirstName,
                       LastName = ModelFactoryTestData.LastName,
                       Password = ModelFactoryTestData.Password,
                       TelephoneNumber = ModelFactoryTestData.TelephoneNumber
                   };
        }

        public static CreateGolfClubViewModel GetCreateGolfClubViewModel()
        {
            return new CreateGolfClubViewModel
                   {
                       Name = ModelFactoryTestData.ClubName,
                       PostalCode = ModelFactoryTestData.PostalCode,
                       TelephoneNumber = ModelFactoryTestData.ClubTelephoneNumber,
                       AddressLine1 = ModelFactoryTestData.AddressLine1,
                       AddressLine2 = ModelFactoryTestData.AddressLine2,
                       EmailAddress = ModelFactoryTestData.EmailAddress,
                       Region = ModelFactoryTestData.Region,
                       Town = ModelFactoryTestData.Town,
                       Website = ModelFactoryTestData.Website
                   };
        }

        public static GetGolfClubResponse GetGetGolfClubResponse()
        {
            return new GetGolfClubResponse
                   {
                       Name = ModelFactoryTestData.ClubName,
                       Town = ModelFactoryTestData.Town,
                       Website = ModelFactoryTestData.Website,
                       Region = ModelFactoryTestData.Region,
                       AddressLine1 = ModelFactoryTestData.AddressLine1,
                       AddressLine2 = ModelFactoryTestData.AddressLine2,
                       EmailAddress = ModelFactoryTestData.EmailAddress,
                       PostalCode = ModelFactoryTestData.PostalCode,
                       TelephoneNumber = ModelFactoryTestData.TelephoneNumber,
                       Id = ModelFactoryTestData.ClubId
                   };
        }

        public static Guid GolfCourseId = Guid.Parse("4CA78A99-1867-472D-9BEA-E6ABF96054E1");
        public static String GolfCourseName = "Test Course";
        public static String GolfCourseTeeColour = "White";
        public static Int32 GolfCourseStandardScratchScore = 70;

        public static Int32 HoleNumber1StrokeIndex = 10;

        public static Int32 HoleNumber1Par = 4;

        public static Int32 HoleNumber1Yards = 348;

        public static Int32 HoleNumber10Par = 4;

        public static Int32 HoleNumber10StrokeIndex = 3;

        public static Int32 HoleNumber10Yards = 399;

        public static Int32 HoleNumber11Par = 4;

        public static Int32 HoleNumber11StrokeIndex = 13;

        public static Int32 HoleNumber11Yards = 401;

        public static Int32 HoleNumber12Par = 4;

        public static Int32 HoleNumber12StrokeIndex = 1;

        public static Int32 HoleNumber12Yards = 401;

        public static Int32 HoleNumber13Par = 5;

        public static Int32 HoleNumber13StrokeIndex = 11;

        public static Int32 HoleNumber13Yards = 530;

        public static Int32 HoleNumber14Par = 3;

        public static Int32 HoleNumber14StrokeIndex = 5;

        public static Int32 HoleNumber14Yards = 196;

        public static Int32 HoleNumber15Par = 4;

        public static Int32 HoleNumber15StrokeIndex = 7;

        public static Int32 HoleNumber15Yards = 355;

        public static Int32 HoleNumber16Par = 4;

        public static Int32 HoleNumber16StrokeIndex = 15;

        public static Int32 HoleNumber16Yards = 243;

        public static Int32 HoleNumber17Par = 4;

        public static Int32 HoleNumber17StrokeIndex = 17;

        public static Int32 HoleNumber17Yards = 286;

        public static Int32 HoleNumber18Par = 4;

        public static Int32 HoleNumber18StrokeIndex = 9;

        public static Int32 HoleNumber18Yards = 399;

        public static Int32 HoleNumber2Par = 4;

        public static Int32 HoleNumber2StrokeIndex = 4;

        public static Int32 HoleNumber2Yards = 402;

        public static Int32 HoleNumber3Par = 3;

        public static Int32 HoleNumber3StrokeIndex = 14;

        public static Int32 HoleNumber3Yards = 207;

        public static Int32 HoleNumber4Par = 4;

        public static Int32 HoleNumber4StrokeIndex = 8;

        public static Int32 HoleNumber4Yards = 405;

        public static Int32 HoleNumber5Par = 4;

        public static Int32 HoleNumber5StrokeIndex = 2;

        public static Int32 HoleNumber5Yards = 428;

        public static Int32 HoleNumber6Par = 5;

        public static Int32 HoleNumber6StrokeIndex = 12;

        public static Int32 HoleNumber6Yards = 477;

        public static Int32 HoleNumber7Par = 3;

        public static Int32 HoleNumber7StrokeIndex = 16;

        public static Int32 HoleNumber7Yards = 186;

        public static Int32 HoleNumber8Par = 4;

        public static Int32 HoleNumber8StrokeIndex = 6;

        public static Int32 HoleNumber8Yards = 397;

        public static Int32 HoleNumber9Par = 3;

        public static Int32 HoleNumber9StrokeIndex = 18;

        public static Int32 HoleNumber9Yards = 130;

        public static MeasuredCourseViewModel GetMeasuredCourseViewModel()
        {
            return new MeasuredCourseViewModel
                   {
                       Name = ModelFactoryTestData.GolfCourseName,
                       StandardScratchScore = ModelFactoryTestData.GolfCourseStandardScratchScore,
                       TeeColour = ModelFactoryTestData.GolfCourseTeeColour,
                       HoleNumber1StrokeIndex = ModelFactoryTestData.HoleNumber1StrokeIndex,
                       HoleNumber2StrokeIndex = ModelFactoryTestData.HoleNumber2StrokeIndex,
                       HoleNumber3StrokeIndex = ModelFactoryTestData.HoleNumber3StrokeIndex,
                       HoleNumber4StrokeIndex = ModelFactoryTestData.HoleNumber4StrokeIndex,
                       HoleNumber5StrokeIndex = ModelFactoryTestData.HoleNumber5StrokeIndex,
                       HoleNumber6StrokeIndex = ModelFactoryTestData.HoleNumber6StrokeIndex,
                       HoleNumber7StrokeIndex = ModelFactoryTestData.HoleNumber7StrokeIndex,
                       HoleNumber8StrokeIndex = ModelFactoryTestData.HoleNumber8StrokeIndex,
                       HoleNumber9StrokeIndex = ModelFactoryTestData.HoleNumber9StrokeIndex,
                       HoleNumber10StrokeIndex = ModelFactoryTestData.HoleNumber10StrokeIndex,
                       HoleNumber11StrokeIndex = ModelFactoryTestData.HoleNumber11StrokeIndex,
                       HoleNumber12StrokeIndex = ModelFactoryTestData.HoleNumber12StrokeIndex,
                       HoleNumber13StrokeIndex = ModelFactoryTestData.HoleNumber13StrokeIndex,
                       HoleNumber14StrokeIndex = ModelFactoryTestData.HoleNumber14StrokeIndex,
                       HoleNumber15StrokeIndex = ModelFactoryTestData.HoleNumber15StrokeIndex,
                       HoleNumber16StrokeIndex = ModelFactoryTestData.HoleNumber16StrokeIndex,
                       HoleNumber17StrokeIndex = ModelFactoryTestData.HoleNumber17StrokeIndex,
                       HoleNumber18StrokeIndex = ModelFactoryTestData.HoleNumber18StrokeIndex,

                       HoleNumber1Yards = ModelFactoryTestData.HoleNumber1Yards,
                       HoleNumber2Yards = ModelFactoryTestData.HoleNumber2Yards,
                       HoleNumber3Yards = ModelFactoryTestData.HoleNumber3Yards,
                       HoleNumber4Yards = ModelFactoryTestData.HoleNumber4Yards,
                       HoleNumber5Yards = ModelFactoryTestData.HoleNumber5Yards,
                       HoleNumber6Yards = ModelFactoryTestData.HoleNumber6Yards,
                       HoleNumber7Yards = ModelFactoryTestData.HoleNumber7Yards,
                       HoleNumber8Yards = ModelFactoryTestData.HoleNumber8Yards,
                       HoleNumber9Yards = ModelFactoryTestData.HoleNumber9Yards,
                       HoleNumber10Yards = ModelFactoryTestData.HoleNumber10Yards,
                       HoleNumber11Yards = ModelFactoryTestData.HoleNumber11Yards,
                       HoleNumber12Yards = ModelFactoryTestData.HoleNumber12Yards,
                       HoleNumber13Yards = ModelFactoryTestData.HoleNumber13Yards,
                       HoleNumber14Yards = ModelFactoryTestData.HoleNumber14Yards,
                       HoleNumber15Yards = ModelFactoryTestData.HoleNumber15Yards,
                       HoleNumber16Yards = ModelFactoryTestData.HoleNumber16Yards,
                       HoleNumber17Yards = ModelFactoryTestData.HoleNumber17Yards,
                       HoleNumber18Yards = ModelFactoryTestData.HoleNumber18Yards,

                       HoleNumber1Par = ModelFactoryTestData.HoleNumber1Par,
                       HoleNumber2Par = ModelFactoryTestData.HoleNumber2Par,
                       HoleNumber3Par = ModelFactoryTestData.HoleNumber3Par,
                       HoleNumber4Par = ModelFactoryTestData.HoleNumber4Par,
                       HoleNumber5Par = ModelFactoryTestData.HoleNumber5Par,
                       HoleNumber6Par = ModelFactoryTestData.HoleNumber6Par,
                       HoleNumber7Par = ModelFactoryTestData.HoleNumber7Par,
                       HoleNumber8Par = ModelFactoryTestData.HoleNumber8Par,
                       HoleNumber9Par = ModelFactoryTestData.HoleNumber9Par,
                       HoleNumber10Par = ModelFactoryTestData.HoleNumber10Par,
                       HoleNumber11Par = ModelFactoryTestData.HoleNumber11Par,
                       HoleNumber12Par = ModelFactoryTestData.HoleNumber12Par,
                       HoleNumber13Par = ModelFactoryTestData.HoleNumber13Par,
                       HoleNumber14Par = ModelFactoryTestData.HoleNumber14Par,
                       HoleNumber15Par = ModelFactoryTestData.HoleNumber15Par,
                       HoleNumber16Par = ModelFactoryTestData.HoleNumber16Par,
                       HoleNumber17Par = ModelFactoryTestData.HoleNumber17Par,
                       HoleNumber18Par = ModelFactoryTestData.HoleNumber18Par
                   };
        }

        public static GetMeasuredCourseListResponse GetMeasuredCourseListResponse()
        {
            return new GetMeasuredCourseListResponse
                   {
                       GolfClubId = ModelFactoryTestData.ClubId,
                       MeasuredCourses = new List<MeasuredCourseListResponse>
                                         {
                                             new MeasuredCourseListResponse
                                             {
                                                 TeeColour = ModelFactoryTestData.GolfCourseTeeColour,
                                                 Name = ModelFactoryTestData.GolfCourseName,
                                                 StandardScratchScore = ModelFactoryTestData.GolfCourseStandardScratchScore,
                                                 MeasuredCourseId = ModelFactoryTestData.GolfCourseId
                                             }
                                         }
                   };
        }
    }
}