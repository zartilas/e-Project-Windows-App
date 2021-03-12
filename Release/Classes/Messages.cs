using System;

namespace e_Projects.Classes
{
    internal static class Messages // Messages class, those messages are widely used in the program.
    {
        // Error messages
        public static string error_message_email_exists = "● Το email που δώσατε υπάρχει ήδη!";

        public static string error_message_reg_id_exists = "● Ο Αριθμός Μητρώου που δώσατε υπάρχει ήδη!";
        public static string error_message_empty_fields = "● Δεν έχετε συμπληρώσει όλα τα πεδία της φόρμας!";
        public static string error_message_login_credentials = "Τα στοιχεία σύνδεσης είναι λανθασμένα!";

        // Confirmation messages
        public static string message_registration_completed = "Η εγγραφή σας έχει ολοκληρωθεί!\nΜπορείτε να συνδεθείτε.";

        // Tooltips
        public static string tooltip_button_project_desc = "ΠΕΡΙΓΡΑΦΗ ΕΡΓΑΣΙΑΣ";

        public static string tooltip_button_more_info = "ΠΕΡΙΣΣΟΤΕΡΕΣ ΠΛΗΡΟΦΟΡΙΕΣ";
        public static string tooltip_button_download_zip = "ΛΗΨΗ ΑΡΧΕΙΟΥ ZIP";
        //
        public static string tooltip_button_modify_user = "ΕΠΕΞΕΡΓΑΣΙΑ ΧΡΗΣΤΗ";
        //
        public static string tooltip_button_delete_team = "ΔΙΑΓΡΑΦΗ ΟΜΑΔΑΣ";
        public static string tooltip_button_delete_user = "ΔΙΑΓΡΑΦΗ ΧΡΗΣΤΗ";
        public static string tooltip_button_delete_assignment = "ΔΙΑΓΡΑΦΗ ΕΡΓΑΣΙΑΣ";
        public static string tooltip_button_set_grade = "ΚΑΤΑΧΩΡΙΣΗ ΒΑΘΜΟΥ ΟΜΑΔΑΣ";
        public static string tooltip_button_add_team = "ΔΗΜΙΟΥΡΓΙΑ ΟΜΑΔΑΣ ΓΙΑ ΑΥΤΗ ΤΗΝ ΕΡΓΑΣΙΑ";
        public static string tooltip_button_upload_file = "ΥΠΟΒΟΛΗ ΕΡΓΑΣΙΑΣ (ΑΡΧΕΊΟ ZIP)";
        public static string tooltip_button_file_already_uploaded = "Η ΕΡΓΑΣΙΑ ΕΧΕΙ ΗΔΗ ΥΠΟΒΛΗΘΕΙ ΑΛΛΑ ΜΠΟΡΕΙΤΕ\nΝΑ ΤΗΝ ΞΑΝΑ ΥΠΟΒΑΛΕΤΕ.";
        public static string tooltip_no_subjects_available = "ΔΕΝ ΥΠΑΡΧΟΥΝ ΜΑΘΗΜΑΤΑ";
        public static string tooltip_add_more_students = "ΠΡΟΣΘΗΚΗ ΠΕΡΙΣΣΟΤΕΡΩΝ ΜΕΛΩΝ ΟΜΑΔΑΣ";
        public static string tooltip_button_delete_student_from_team = "ΔΙΑΓΡΑΦΗ ΦΟΙΤΗΤΗ";

        // MessageBoxes
        public static string msgbox_universal_confirmation = "Επιβεβαίωση Υποβολής";

        public static string msgbox_universal_error_confirmation = "Σφάλμα";

        public static string msgbox_insert_assignment_title = "Επιβεβαίωση Διαγραφής Εργασίας";
        public static string msgbox_insert_assignment_content = "Η εργασία έχει προστεθεί επιτυχώς!";

        public static string msgbox_user_update_title = "Επιβεβαίωση Επεξεργασίας Χρήστη";
        public static string msgbox_user_update_content = "Ο χρήστης έχει επεξεργαστεί επιτυχώς!";
        public static string msgbox_user_update_content_error = "Προέκυψε κάποιο σφάλμα κατά την υποβολή!";

        public static string msgbox_delete_assignment_title = "Επιβεβαίωση Διαγραφής Εργασίας";

        public static string msgbox_delete_assignment_content = "Είστε σίγουρος ότι θέλετε να διαγράψετε αυτή την εργασία;" +
                                                                "\nΗ διαγραφή είναι οριστική!";

        public static string msgbox_delete_team_title = "Επιβεβαίωση Διαγραφής Ομάδας";
        public static string msgbox_delete_team_content = "Είστε σίγουρος ότι θέλετε να διαγράψετε αυτή την ομάδα;" +
                                                          "\nΗ διαγραφή είναι οριστική!";

        public static string msgbox_delete_user_title = "Επιβεβαίωση Διαγραφής Χρήστη";
        public static string msgbox_delete_user_content = "Είστε σίγουρος ότι θέλετε να διαγράψετε αυτόν τον χρήστη;" +
                                                          "\nΗ διαγραφή είναι οριστική!";

        public static string msgbox_file_uploaded_title = "Υποβολή Επιτυχής";
        public static string msgbox_file_uploaded_content = "Το αρχείο σας έχει υποβληθεί επιτυχώς.";
        public static string msgbox_file_saved_title = "Αποθήκευση Επιτυχής";
        public static string msgbox_file_saved_content = "Το αρχείο έχει αποθηκευτεί επιτυχώς.";

        public static string msgbox_grade_assigned = "Ο βαθμός της ομάδας έχει υποβληθεί!";
        public static string msgbox_grade_not_assigned_error = "Προέκυψε κάποιο σφάλμα κατά την υποβολή!";

        public static string msgbox_Team_Added_Confirmation = "Η ομάδα έχει προστεθεί επιτυχώς!";

        public static string msgbox_invalid_Name_error = "Κάποιο Όνομα δεν είναι σωστά καταχωρημένο";
        public static string msgbox_invalid_Surname_error = "Κάποιο Επίθετο δεν είναι σωστά καταχωρημένο";

        public static string msgbox_invalid_AM_format_error = "Κάποιος Αριθμός Μητρώου δεν είναι σωστά καταχωρημένος!\n" +
                                                              "Η μορφή είναι PXXXXX";

        public static string msgbox_invalid_Email_error = "Κάποιο Email δεν είναι σωστά καταχωρημένο";
        public static string msgbox_AM_Not_Registered = "Κάποιος απο τους αρ. μητρώου που είναι καταχωρημένοι\nδεν είναι εγγεγραμένος στην εφαρμογή!";
        public static string msgbox_AM_Is_In_Another_Team_Of_The_Same_Project = "Κάποιος απο τους αρ. μητρώου που είναι καταχωρημένος\nείναι δηλωμένος σε άλλη ομάδα της ίδιας εργασίας!";

        public static String msgbox_grade_input_error(String percentage)
        {
            return "Ο βαθμός της ομάδας δεν μπορεί να είναι μεγαλύτερος του " + percentage;
        }

        public static String msgbox_maximum_student_panels_error(int max_students_num)
        {
            return "Το όριο για τα μέλη της ομάδας είναι στα " + max_students_num + " άτομα!";
        }

        // Universal
        public static string msg_yes = "ΝΑΙ";

        public static string msg_no = "ΟΧΙ";
        public static string msg_status_active = "ΑΝΟΙΧΤΟ";
        public static string msg_status_inactive = "ΚΛΕΙΣΤΟ";
    }
}