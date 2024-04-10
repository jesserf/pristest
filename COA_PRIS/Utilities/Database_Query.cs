﻿using COA_PRIS.Utilities;
using Mysqlx.Crud;
using Org.BouncyCastle.Asn1.X9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COA_PRIS
{
    internal class Database_Query
    {
        public static readonly string get_acc = "SELECT COUNT(*) FROM user_cred_table WHERE user_name = '{0}'";
        public static readonly string check_acc_status = "SELECT status FROM user_info_table WHERE user_name = '{0}'";

        public static readonly string deact_acc = "UPDATE user_info_table SET status = 0 WHERE user_name = '{0}'";
        public static readonly string get_pass = "SELECT password FROM user_cred_table WHERE user_name = '{0}'";

        public static string last_query;

        #region Activity Logging
        public static readonly string logged_in = "INSERT INTO log_table (user_name, activity, activity_datetime) VALUES ('{0}', '{1}', CURRENT_TIMESTAMP)";
        public static readonly string logged_out = "INSERT INTO log_table (user_name, activity, activity_datetime) VALUES ('{0}', '{1}', CURRENT_TIMESTAMP)";
        public static readonly string display_logs = "SELECT user_name, activity, activity_datetime FROM log_table";
        public static readonly string display_three_logs = "SELECT user_name, activity, activity_datetime FROM log_table LIMIT {0}, 15";
        public static readonly string display_specific_logs = "SELECT user_name, activity, activity_datetime FROM log_table WHERE {0} LIKE '%{1}%'";
        public static readonly string display_ten_specific_logs = "SELECT user_name, activity, activity_datetime FROM log_table WHERE {0} LIKE '%{1}%' LIMIT {2}, 15";
        public static readonly string display_specific_logs_by_date = "SELECT user_name, activity, activity_datetime FROM log_table WHERE activity_datetime BETWEEN '{0}' AND '{1}' LIMIT {2}, 15";
        public static readonly string display_specified_logs = "SELECT user_name, activity, activity_datetime FROM log_table WHERE activity_datetime BETWEEN '{0}' AND '{1}' AND {4} LIKE '%{3}%' LIMIT {2}, 15";
        public static readonly string count_logs = "SELECT COUNT(*) FROM log_table";
        //public static readonly string login_attempt = "INSERT INTO log_table (user_name, activity, activity_datetime) VALUES ('{0}', 'Attempted to login', CURRENT_TIMESTAMP)";
        
        #endregion


        public static readonly string get_top_employee_rec = "SELECT employee_no FROM emp_info_table ORDER BY employee_no DESC LIMIT 1";

        public static readonly string get_recent_code = "SELECT code FROM {0} ORDER BY code DESC LIMIT 1";

        public static readonly string get_code_info = "SELECT code, num_length, initial_num FROM code_table WHERE code_table.table = '{0}'";

        public static readonly string delete_record_by_id = "UPDATE {0} SET status = 0 WHERE code = '{1}';";

        #region Project Requests

        public static readonly string get_all_project_records = "SELECT * FROM docu_info_table";

        public static readonly string get_general_project_records_by_date = "SELECT * FROM docu_info_table WHERE {0} BETWEEN '{1}' AND '{2}'";

        //public static readonly string get_specific_project_records_by_date = "SELECT * FROM docu_info_table WHERE {0} BETWEEN '{1}' AND '{2}' AND {3} LIKE '%{4}%'";

        public static readonly string get_specific_project_records_by_date = "SELECT * FROM docu_info_table WHERE {0} BETWEEN '{1}' AND '{2}' AND '{3}' IN \r" +
                                                                                "(document_id, document_code, document_no, amount, title, subject)";

        public static readonly string get_specific_project_records_by_date2 = "SELECT * FROM docu_info_table WHERE {0} BETWEEN '{1}' AND '{2}' AND '{3}' IN \r" +
                                                                                "(document_id, document_code, document_no, amount, title, subject)";

        #endregion

        public static readonly string get_office_options_by_id = "SELECT office_table.code, office_table.title FROM office_table \r" +
                                                                    "WHERE office_table.sector_code = '{0}' AND office_table.status = 1;";

        public static readonly string get_division_options_by_id = "SELECT division_table.code, division_table.title FROM division_table \r" +
                                                                    "WHERE division_table.office_code = '{0}' AND division_table.status = 1;";

        public static readonly string get_section_options_by_id = "SELECT section_table.code, section_table.title FROM section_table \r" +
                                                                    "WHERE section_table.division_code = '{0}' AND section_table.status = 1;";

        public static readonly string get_position_options = "SELECT position_table.code, position_table.title FROM position_table \r" +
                                                             "WHERE position_table.status = 1;";

        public static readonly string get_section_option = "SELECT section_table.code, section_table.title FROM section_table \r" +
                                                            "WHERE section_table.status = 1;";

        public static readonly string get_employee_record_by_id = "SELECT emp_info_table.full_name, emp_info_table.email, emp_info_table.contact_no, sector_table.code, office_table.code, division_table.code, section_table.code, position_table.code\r" +
                                                                    "FROM emp_info_table \r" +
                                                                    "LEFT JOIN position_table ON emp_info_table.position_code = position_table.code\r" +
                                                                    "LEFT JOIN section_table ON emp_info_table.section_code = section_table.code\r" +
                                                                    "LEFT JOIN division_table ON section_table.division_code = division_table.code\r" +
                                                                    "LEFT JOIN office_table ON division_table.office_code = office_table.code\r" +
                                                                    "LEFT JOIN sector_table ON office_table.sector_code = sector_table.code\r" +
                                                                    "WHERE emp_info_table.code = '{0}' AND emp_info_table.status = 1;";


        public static readonly string update_employee_record_by_id = "UPDATE emp_info_table SET \r\nemp_info_table.full_name = '{0}',\r\nemp_info_table.email = '{1}',\r\nemp_info_table.contact_no = '{2}',\r\nemp_info_table.section_code = '{3}',\r\nemp_info_table.position_code = '{4}',\r\nemp_info_table.updated_by = '{5}',\r\nemp_info_table.updated_date = CURRENT_TIMESTAMP()\r\nWHERE emp_info_table.code = '{6}' AND emp_info_table.status = 1;";



        public static readonly string get_audit_trail_by_id = "SELECT created_by, created_date, updated_by, updated_date FROM {0} WHERE code = '{1}';";

        #region Maintenance GET Table Queries

        public static readonly string get_all_agency_records = "SELECT  agency_table.code, agency_table.title, agency_table.description, cluster_table.title\r" +
                                                                "FROM agency_table LEFT JOIN cluster_table ON agency_table.cluster_code = cluster_table.code\r" +
                                                                "WHERE agency_table.status = 1;";
        
        public static readonly string get_all_cluster_records = "SELECT cluster_table.code, cluster_table.title, cluster_table.description, sector_table.title \r" +
                                                                "FROM cluster_table LEFT JOIN sector_table ON cluster_table.sector_code = sector_table.code\r" +
                                                                "WHERE cluster_table.status = 1;";

        public static readonly string get_all_contractor_records = "SELECT contractor_table.code, contractor_table.title, contractor_table.description FROM contractor_table \r" +
                                                                    "WHERE contractor_table.status = 1;";

        public static readonly string get_all_division_records = "SELECT division_table.code, division_table.title, division_table.description, office_table.title \r" +
                                                                    "FROM division_table LEFT JOIN office_table ON division_table.office_code = office_table.code\r" +
                                                                    "WHERE division_table.status = 1;";

        public static readonly string get_all_nature_records = "SELECT nature_table.code, nature_table.title, nature_table.description FROM nature_table\r" +
                                                                    "WHERE nature_table.status = 1;";


        public static readonly string get_all_office_records = "SELECT office_table.code, office_table.title, office_table.description, sector_table.title \r" +
                                                                "FROM office_table LEFT JOIN sector_table ON office_table.sector_code = sector_table.code\r" +
                                                                "WHERE office_table.status = 1;";

        public static readonly string get_all_position_records = "SELECT position_table.code, position_table.title, position_table.description FROM position_table\r" +
                                                                "WHERE position_table.status = 1;";

        public static readonly string get_all_section_records = "SELECT section_table.code, section_table.title, section_table.description, division_table.title\r" +
                                                                "FROM section_table LEFT JOIN division_table ON section_table.division_code = division_table.code\r" +
                                                                "WHERE section_table.status = 1;";

        public static readonly string get_all_sector_records = "SELECT sector_table.code, sector_table.title, sector_table.description FROM sector_table\r" +
                                                                "WHERE sector_table.status= 1;";
       
        public static readonly string get_cluster_options = "SELECT cluster_table.code, cluster_table.title FROM cluster_table";

        public static readonly string get_office_options = "SELECT office_table.code, office_table.title FROM office_table WHERE office_table.status = 1 ;";

        public static readonly string get_sector_options = "SELECT sector_table.code,sector_table.title FROM sector_table WHERE sector_table.status = 1";

        public static readonly string get_division_options = "SELECT division_table.code,division_table.title FROM division_table WHERE division_table.status = 1";


        #endregion

        #region Maintenance SET Record Queries

        public static readonly string set_new_agency = "INSERT INTO agency_table (code, title, description, cluster_code, status, created_by, created_date)\r" +
                                                        "VALUES ('{0}','{1}','{2}','{3}', 1,'{4}', CURRENT_TIMESTAMP())";

        public static readonly string set_new_cluster = "INSERT INTO cluster_table (code, title, description, sector_code, status, created_by, created_date)\r" +
                                                        "VALUES ('{0}','{1}','{2}','{3}', 1,'{4}', CURRENT_TIMESTAMP());";

        public static readonly string set_new_contractor = "INSERT INTO contractor_table (code, title, description, status, created_by, created_date)\r" +
                                                        "VALUES ('{0}','{1}','{2}', 1,'{3}', CURRENT_TIMESTAMP());";

        public static readonly string set_new_nature = "INSERT INTO nature_table (code, title, description, status, created_by, created_date)\r" +
                                                        "VALUES ('{0}','{1}','{2}', 1,'{3}', CURRENT_TIMESTAMP());";

        public static readonly string set_new_position = "INSERT INTO position_table (code, title, description, status, created_by, created_date)\r" +
                                                         "VALUES ('{0}','{1}','{2}', 1,'{3}', CURRENT_TIMESTAMP());";

        public static readonly string set_new_sector = "INSERT INTO sector_table (code, title, description, status, created_by, created_date)\r" +
                                                        "VALUES ('{0}','{1}','{2}', 1,'{3}', CURRENT_TIMESTAMP());";

        public static readonly string set_new_section = "INSERT INTO section_table (code, title, description, division_code, status, created_by, created_date)\r" +
                                                        "VALUES ('{0}','{1}','{2}','{3}', 1,'{4}', CURRENT_TIMESTAMP())";

        public static readonly string set_new_office = "INSERT INTO office_table (code, title, description, sector_code, status, created_by, created_date)\r" +
                                                        "VALUES ('{0}','{1}','{2}','{3}', 1,'{4}', CURRENT_TIMESTAMP())";
        public static readonly string set_new_division = "INSERT INTO division_table (code, title, description, office_code, status, created_by, created_date)\r" +
                                                     "VALUES ('{0}','{1}','{2}','{3}', 1,'{4}', CURRENT_TIMESTAMP())";

        #endregion

        #region EMPLOYEE


        public static readonly string get_employee_records = "SELECT emp_info_table.code, emp_info_table.full_name, office_table.title, position_table.title,\r" +
                                                                "CASE \r" +
                                                                "WHEN emp_info_table.status = 1 THEN 'ACTIVE'\r" +
                                                                "WHEN emp_info_table.status = 2 THEN 'INACTIVE'\r" +
                                                                "ELSE 'TERMINATED'\r\nEND\r\nAS status\r" +
                                                            "FROM emp_info_table \r" +
                                                            "LEFT JOIN position_table ON emp_info_table.position_code = position_table.code\r" +
                                                            "LEFT JOIN section_table ON emp_info_table.section_code = section_table.code\r" +
                                                            "LEFT JOIN division_table ON section_table.division_code = division_table.code\r" +
                                                            "LEFT JOIN office_table ON division_table.office_code = office_table.code\r\nWHERE emp_info_table.status = 1";



        public static readonly string set_new_employee = "INSERT INTO emp_info_table(code,full_name,email,contact_no,section_code,position_code,status,created_by,created_date)\r" +
                                                         "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}', 1,'{6}', CURRENT_TIMESTAMP())";
        #endregion



        #region GET Record Queries
        public static readonly string get_agency_record_by_id = "SELECT agency_table.title, agency_table.description, agency_table.cluster_code FROM agency_table\r" +
                                                                "WHERE agency_table.code = '{0}' and agency_table.status = 1;";

        public static readonly string get_cluster_record_by_id = "SELECT agency_table.title, agency_table.description, agency_table.cluster_code FROM agency_table\r" +
                                                                "WHERE agency_table.code = '{0}' and agency_table.status = 1;";


        #endregion

        #region UPDATE Record Queries
        public static readonly string update_agency_record_by_id = "UPDATE agency_table SET \r" +
                                                                "agency_table.title = '{0}', agency_table.description = '{1}', \r" +
                                                                "agency_table.cluster_code = '{2}', agency_table.updated_by = '{3}',\r" +
                                                                "agency_table.updated_date = CURRENT_TIMESTAMP()\r" +
                                                                "WHERE agency_table.code = '{4}' and agency_table.status = 1";
        
        
        
        #endregion
    }
}
