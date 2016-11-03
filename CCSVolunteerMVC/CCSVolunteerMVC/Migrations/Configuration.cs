namespace CCSVolunteerMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CCSVolunteerMVC.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<CCSVolunteerMVC.DAL.CCSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CCSVolunteerMVC.DAL.CCSContext context)
        {


            /**********************************************************************************************************************/



            /*INSERT INTO `Ethnicity` (`ethID`, `ethName`) VALUES
            (1, 'Other'),
            (2, 'White'),
            (3, 'Black or African-American'),
            (4, 'Asian'),
            (5, 'Hispanic'),
            (6, 'American Indian or Alaskan Native'),
            (7, 'Native Hawaiian or Pacific Islander');*/

//            var ethnicity = new list<ethnicity>(){
//    new ethnicity(){ ethnicityid = 1, ethname = "other"},
//    new ethnicity(){ ethnicityid = 2, ethname = "white"},
//    new ethnicity(){ ethnicityid = 3, ethname = "black or african-american"},
//    new ethnicity(){ ethnicityid = 4, ethname = "asian"},
//    new ethnicity(){ ethnicityid = 5, ethname = "hispanic"},
//    new ethnicity(){ ethnicityid = 6, ethname = "american indian or alaskan native"},
//    new ethnicity(){ ethnicityid = 7, ethname = "native hawaiian or pacific islander"}
//};
//            ethnicity.foreach(e => context.ethnicities.add(e));
//            context.savechanges();

//            /************************************************************************************************************************/
//            /*insert into `foreignlanguage` (`foreignlangid`, `foreignlangname`) values
//            (1, 'spanish'),
//            (2, 'portuguese'),
//            (3, 'french'),
//            (4, 'german'),
//            (5, 'italian'),
//            (6, 'japanese'),
//            (7, 'manderine'),
//            (8, 'cantonese');*/

//            var foreignlanguage = new list<foreignlanguage>(){
//    new foreignlanguage(){ foreignlanguageid = 1, foreignlangname = "spanish"},
//    new foreignlanguage(){ foreignlanguageid = 2, foreignlangname = "portuguese"},
//    new foreignlanguage(){ foreignlanguageid = 3, foreignlangname = "french"},
//    new foreignlanguage(){ foreignlanguageid = 4, foreignlangname = "german"},
//    new foreignlanguage(){ foreignlanguageid = 5, foreignlangname = "italian"},
//    new foreignlanguage(){ foreignlanguageid = 6, foreignlangname = "japanese"},
//    new foreignlanguage(){ foreignlanguageid = 7, foreignlangname = "manderine"},
//    new foreignlanguage(){ foreignlanguageid = 8, foreignlangname = "cantonese"}
// };

//            foreignlanguage.foreach(f => context.foreignlanguages.add(f));
//            context.savechanges();
   
//            /****************************************************************************************************************************/
//            /*insert into `volunteer` (`volid`, `volfirstname`, `vollastname`, `voldob`, `volpin`, `volgender`, `voljoindate`, `voliscourtordered`, `ethid`, `vollsclient`, `vollsactive`) values
//            (63, 'adam', 'neese', '1970-01-01', 0, 'male', '2016-07-05 14:07:19', 0, 2, b'0', b'0'),
//            (64, 'ray', 'tremblay', '1970-01-01', 0, 'male', '2016-07-05 14:10:53', 0, 2, b'0', b'0'),
//            (65, 'lyle', 'rowley', '1970-01-01', 0, 'male', '2016-07-05 14:14:13', 0, 2, b'0', b'0'),
//            (66, 'christine ', 'burson', '1970-04-26', 0, 'female', '2016-07-05 14:15:23', 0, 2, b'0', b'0'),
//            (67, 'john', 'tuke', '1970-01-01', 0, 'male', '2016-07-05 14:16:15', 0, 2, b'0', b'0'),
//            (68, 'iven ', 'king', '1970-01-01', 0, 'male', '2016-07-05 14:17:15', 0, 3, b'0', b'0'),
//            (69, 'marco', 'lopez', '1970-01-01', 0, 'male', '2016-07-05 14:22:18', 0, 5, b'0', b'0');*/

//            var volunteer = new list<volunteer>(){
//    new volunteer(){ volunteerid = 63, volfirstname = "adam", vollastname = "neese", voldob = datetime.parse("1970-01-01"), volpin = 0, volgender = "male", voljoindate = datetime.parse("2016-07-05 14:07:19"), volscourtordered = 0, ethid = 2, volsclient = 0, volsactive = 0},
//    new volunteer(){ volunteerid = 64, volfirstname = "ray", vollastname = "tremblay", voldob = datetime.parse("1970-01-01"), volpin = 0, volgender = "male", voljoindate = datetime.parse("2016-07-05 14:10:53"), volscourtordered = 0, ethid = 2, volsclient = 0, volsactive = 0},
//    new volunteer(){ volunteerid = 65, volfirstname = "lyle", vollastname = "rowley", voldob = datetime.parse("1970-01-01"), volpin = 0, volgender = "male", voljoindate = datetime.parse("2016-07-05 14:14:13"), volscourtordered = 0, ethid = 2, volsclient = 0, volsactive = 0},
//    new volunteer(){ volunteerid = 66, volfirstname = "christine", vollastname = "burson", voldob = datetime.parse("1970-04-26"), volpin = 0, volgender = "female", voljoindate = datetime.parse("2016-07-05 14:15:23"), volscourtordered = 0, ethid = 2, volsclient = 0, volsactive = 0},
//    new volunteer(){ volunteerid = 67, volfirstname = "john", vollastname = "tuke", voldob = datetime.parse("1970-01-01"), volpin = 0, volgender = "male", voljoindate = datetime.parse("2016-07-05 14:16:15"), volscourtordered = 0, ethid = 2, volsclient = 0, volsactive = 0},
//    new volunteer(){ volunteerid = 68, volfirstname = "iven", vollastname = "king", voldob = datetime.parse("1970-01-01"), volpin = 0, volgender = "male", voljoindate = datetime.parse("2016-07-05 14:17:15"), volscourtordered = 0, ethid = 3, volsclient = 0, volsactive = 0},
//    new volunteer(){ volunteerid = 69, volfirstname = "marco", vollastname = "lopez", voldob = datetime.parse("1970-01-01"), volpin = 0, volgender = "male", voljoindate = datetime.parse("2016-07-05 14:22:18"), volscourtordered = 0, ethid = 5, volsclient = 0, volsactive = 0}
//};
//            volunteer.foreach(v => context.volunteers.add(v));
//            context.savechanges();
//            /*****************************************************************************************************************************************/
//            /*insert into `volunteergroup` (`volgrpid`, `volgrpname`, `volgrpusername`, `volgrppasswordhash`, `volgrpcontactfirstname`, `volgrpcontactlastname`, `volgrpaddress1`, `volgrpaddress2`, `volgrpcity`, `volgrpstate`, `volgrpzip`, `volgrpphone`, `volgrpemail`, `volgrpactive`) values
//            (49972, 'st catherine of sienna', '', '', 'polly', 'granger', '2761 swasont way', '', 'slc', 'ut', '84117', '801-277-8733', 'polly.granger@yahoo.com', b'0'),
//            (49973, 'st martin de porres', '', '', 'ethel', 'clark', '6239 s 700 w', '', 'murray', 'ut', '84123', '8012312436', 'einchef@msn.com', b'0'),
//            (49974, 'korean group', '', '', 'eunjoo', 'jeon', '5419 s york st. ', '', 'slc', 'ut', '84121', '8018311445', 'lej0209@gmail.com', b'0'),
//            (49975, 'cathedral of the magdalene', '', '', 'jennifer', 'gibbons', 'p.o. box 171077 ', '', 'slc', 'ut', '84117', '801 277-2118', 'mjgibbonsut@gmail.com', b'0'),
//            (49976, 'cathedral of the magdalene', '', '', 'judy', 'eagan', '', '', '', 'ut', '', '801) 487-2983', 'juditheagen@comcst.net', b'0'),
//            (49977, 'our savior lutheran', '', '', 'ellen silverbratt', '1954 east orchard drive', '1954 east orchard dr', '', 'slc', 'ut', '84106', '801-272-1839', 'mrich@ccsutah.org', b'0'),
//            (49978, 'st martin de porres', '', '', 'betty', 'valdez', '', '', '', 'ut', '', '801 262 7735', 'mrich@ccsutah.org', b'0'),
//            (49979, 'st martin de porres', '', '', 'mary ', 'condas', '', '', '', 'ut', '', '8012663125', 'mdcondas@comcast.net', b'0'),
//            (49980, 'korean group', '', '', 'eunjoo', 'jeon', '5419 s york st.  ', '', 'slc', 'ut', '84117', '801) 831-1445', 'lej0209@gmail.com', b'0'),
//            (49981, 'korean group', '', '', 'kelly', 'park ', '6733 costa cove  ', '', 'slc', 'ut', '84121', '801) 633-3116', 'kkpark35@hotmail.com', b'0'),
//            (49982, 'bureau of land management', '', '', 'connie ', 'mountain', '440 west 200 south s', '', 'slc', 'ut', '84101', '801-539-4234', 'cmountain@blm.gov', b'0'),
//            (49983, 'butler 17th ward', '', '', 'jim', 'garner', '3079 sundrift circle', '', 'slc', 'ut', '84121', '801.634.1977', 'jdgarners@aol.com', b'0'),
//            (49984, 'centenary methodist church', '', '', 'nancy', 'smith', '5515 dunbarton drive', '', 'slc', 'ut', '84117', '801 266 6737', 'mrich@ccsutah.org', b'0'),
//            (49985, 'st.thomas moore', '', '', 'kathleen', 'pachucki', '', '', '', 'ut', '', '801-856-2905', 'kmpachucki@yahoo.com', b'0'),
//            (49986, 'westech engineering, inc.', '', '', 'david', 'rogers', '', '', '', 'ut', '', '8012901504', 'drogers@westech-inc.com', b'0'),
//            (49987, 'blessed sacrament', '', '', 'janet ', 'tezloff ', '2208 new castle driv', '', 'sabdy', 'ut', '84043', '801-943-2094', 'mrich@ccsutah.org', b'0'),
//            (49988, 'blessed sacrament', '', '', 'kerry and brian eckert ', ' eckert ', '', '', '', 'ut', '', '801 565 1858', 'kerry.brian858@yahoo.com', b'0'),
//            (49989, 'blessed sacrament', '', '', 'scott and deb ', 'lutz ', '', '', '', 'ut', '', '801 576 1106', 'scottlutz@live.com', b'0'),
//            (49990, 'st teresa', '', '', 'al romo', 'call the parish', '', '', '', 'ut', '', '801 2553721', 'mrich@ccsutah.org', b'0'),
//            (49991, 'st. teresa', '', '', 'sally', 'milburn', '10443 tarali court ', '', 'south jordan', 'ut', '84095', '801-269-5614', 'smilburn@travelers.com', b'0'),
//            (49992, 'st olaf’s', '', '', 'nancy ', ' graham ', '208 e 1000 s ', '', 'bountiful', 'ut', '84010', '801 295 2684', 'kbuerrenich@msn.com', b'0'),
//            (49993, 'st olaf’s', '', '', 'judy', ' vogel', '2415 e 1900 n', '', 'layton', 'ut', '84040', '801 4281366', 'jvogel1938@hotmail.com', b'0'),
//            (49994, 'worker’s compensation', '', '', 'rachel ', 'lewis ', '100 west town ridge ', '', 'sandy', 'ut', '84070', '385-351-8024', 'rlewis@wcfgroup.com', b'0'),
//            (49995, 'ebay', '', '', 'rebecca', 'richards', '', '', '', 'ut', '', '8015451602', 'rrichards@ebay.com', b'0'),
//            (49996, ' shumway group', '', '', 'randy', 'shumway', '', '', '', 'ut', '', '801-456-6717', 'rshumway@cicerogroup.com', b'0'),
//            (49997, 'japanese church of christ', '', '', 'elaine', 'iwasaki', '3853 quail hollow dr', '', 'slc', 'ut', '84109', '801-651-8389 ', 'heiwasaki@q.com', b'0'),
//            (49998, 'japanese church of christ', '', '', 'david ', 'harada      ', '', '', '', 'ut', '', '801-678-6537 ', 'mrich@ccsutah.org', b'0'),
//            (49999, 'our savior lutheran ', '', '', 'ellen', 'silverbratt', '1954 east orchard dr', '', 'slc', 'ut', '84103', '801 2721839', 'mrich@ccsutha.org', b'0');*/


//            /***********************************************************************************************************************************************/
//            /*insert into `volunteerlanguage` (`vollangid`, `volid`, `foreignlangid`, `vollangfluencylvl`, `vollangliteracylvl`) values
//            (34, 69, 1, 1, 0);*/

//            var volunteerlanguage = new list<volunteerlanguage>(){
//    new volunteerlanguage(){ volunteerlanguageid = 34, volunteerid = 7, foreignlanguageid = 1, vollangfluencylvl = 1, vollangliteracylvl = 0}
//};
//            volunteerlanguage.foreach(v => context.volunteerlanguages.add(v));
//            context.savechanges();
//            /**********************************************************************************************************************************************/
//            /*insert into `volunteertraining` (`voltrnid`, `voltrnname`, `voltrndesc`, `voltrnccsrequired`, `voltrnstaterequired`, `voltrnmonthsvalid`, `voltrnbackgroundlvl`, `voltrnmvr`) values
//            (1, 'cpr', 'cpr', b'1', b'1', 12, 0, b'0'),
//            (2, 'training2', 'text training2', b'0', b'0', 12, 0, b'0');*/

//            var volunteertraining = new list<volunteertraining>(){
//    new volunteertraining(){ volunteertrainingid = 1, voltrnname = "cpr", voltrndesc = "cpr", voltrnccsrequired = 1, voltrnstaterequired = 1, voltrnmonthsvalid = 12, voltrnbackgroundlvl = 0, voltrnmvr = 0},
//    new volunteertraining(){ volunteertrainingid = 2, voltrnname = "training2", voltrndesc = "text training2", voltrnccsrequired = 0, voltrnstaterequired = 0, voltrnmonthsvalid = 12, voltrnbackgroundlvl = 0, voltrnmvr = 0},
//};
//            volunteertraining.foreach(v => context.volunteertrainings.add(v));
//            context.savechanges();

            /************************************************************************************************************************/
//            /*INSERT INTO `UserAccessLevelType` (`userAccessLvlTypeID`, `userAccessLvlTypeName`) VALUES
//            (1, 'Administrator'),
//            (2, 'Employee'),
//            (3, 'Volunteer'),
//            (4, 'User');*/

//            var userAccessLevelType = new List<UserAccessLevelType>(){
//    new UserAccessLevelType(){ userAccessLevelTypeID = 1, userAccessLvlTypeName = "Administrator"},
//    new UserAccessLevelType(){ userAccessLevelTypeID = 2, userAccessLvlTypeName = "Employee"},
//    new UserAccessLevelType(){ userAccessLevelTypeID = 3, userAccessLvlTypeName = "Volunteer"},
//    new UserAccessLevelType(){ userAccessLevelTypeID = 4, userAccessLvlTypeName = "User"}
//};

//            userAccessLevelType.ForEach(u => context.UserAccessLevelType.Add(u));
//            context.SaveChanges();
//            /**************************************************************************************************************************/
//            /*INSERT INTO `UserAccount` (`userAcctID`, `userAcctName`, `userAcctUserName`, `userAcctPassword`, `userAcctAccessLevel`, `userAcctEmail`, `userAcctPhone`) VALUES
//            (20, 'CCSAdmin', 'CCSAdmin', 'CCSAdmin', 1, 'ccsadmin@ccsadmin.org', '000-111-2222'),
//            (21, 'CCSEmployee', 'CCSEmployee', 'CCSEmployee', 2, 'ccsemployee@ccs.org', '000-111-2222');*/

//            var userAccount = new List<UserAccount>(){
//    new UserAccount(){ userAcctID = 20, userAcctName = "CCSAdmin", userAcctUserName = "CCSAdmin", userAcctPassword = "CCSAdmin", userAcctAccessLevel = 1, userAcctEmail = "ccsadmin@ccsadmin.org", userAcctPhone = "000-111-2222" },
//    new UserAccount(){ userAcctID = 21, userAcctName = "CCSEmployee", userAcctUserName = "CCSEmployee", userAcctPassword = "CCSEmployee", userAcctAccessLevel = 2, userAcctEmail = "ccsemployee@ccs.org", userAcctPhone = "000-111-2222" }
//};

//            userAccount.ForEach(u => context.UserAccount.Add(u));
//            context.SaveChanges();



//            /************************************************************************************************************************/
//            /*INSERT INTO `UserAccessLevelType` (`userAccessLvlTypeID`, `userAccessLvlTypeName`) VALUES
//            (1, 'Administrator'),
//            (2, 'Employee'),
//            (3, 'Volunteer'),
//            (4, 'User');*/

//            var userAccessLevelType = new List<UserAccessLevelType>(){
//    new UserAccessLevelType(){ userAccessLevelTypeID = 1, userAccessLvlTypeName = "Administrator"},
//    new UserAccessLevelType(){ userAccessLevelTypeID = 2, userAccessLvlTypeName = "Employee"},
//    new UserAccessLevelType(){ userAccessLevelTypeID = 3, userAccessLvlTypeName = "Volunteer"},
//    new UserAccessLevelType(){ userAccessLevelTypeID = 4, userAccessLvlTypeName = "User"}
//};

//            userAccessLevelType.ForEach(u => context.UserAccessLevelType.Add(u));
//            context.SaveChanges();
        }
    }
}
