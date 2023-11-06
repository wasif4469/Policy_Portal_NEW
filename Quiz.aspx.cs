using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Policy_Portal
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        int attempt = 0;
        int per = 0;
        String constring = "Data Source=crmtest;Initial Catalog=policy_db;User ID=t_graduate;Password=Oracle_123";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["IsLoggedIn"] == null || !(bool)Session["IsLoggedIn"])
            {
                Response.Redirect("/LoginPage.aspx");
            }
            if (!IsPostBack)
            {


                QuestionLists questionLists = GetQuestionsFromDatabase();

                // Access and use the lists as needed
                List<string> questions = questionLists.List1;
                List<string> options1 = questionLists.List2;
                List<string> options2 = questionLists.List3;
                List<string> options3 = questionLists.List4;
                List<string> options4 = questionLists.List5;
                List<string> answers = questionLists.List6;



                // Set the text of each Label control to display the questions
                if (questions.Count >= 1)
                {
                    Label1.Text = "Q1. " + questions[0];
                    Q1.Items[0].Text = options1[0];
                    Q1.Items[1].Text = options2[0];
                    Q1.Items[2].Text = options3[0];
                    Q1.Items[3].Text = options4[0];
                    Session["ans1"] = answers[0];

                }

                if (questions.Count >= 2)
                {
                    Label2.Text = "Q2. " + questions[1];
                    Q2.Items[0].Text = options1[1];
                    Q2.Items[1].Text = options2[1];
                    Q2.Items[2].Text = options3[1];
                    Q2.Items[3].Text = options4[1];
                    Session["ans2"] = answers[1];
                }
                if (questions.Count >= 3)
                {
                    Label3.Text = "Q3. " + questions[2];
                    Q3.Items[0].Text = options1[2];
                    Q3.Items[1].Text = options2[2];
                    Q3.Items[2].Text = options3[2];
                    Q3.Items[3].Text = options4[2];
                    Session["ans3"] = answers[2];
                }
                if (questions.Count >= 4)
                {
                    Label4.Text = "Q4. " + questions[3];
                    Q4.Items[0].Text = options1[3];
                    Q4.Items[1].Text = options2[3];
                    Q4.Items[2].Text = options3[3];
                    Q4.Items[3].Text = options4[3];
                    Session["ans4"] = answers[3];
                }
                if (questions.Count >= 5)
                {
                    Label5.Text = "Q5. " + questions[4];
                    Q5.Items[0].Text = options1[4];
                    Q5.Items[1].Text = options2[4];
                    Q5.Items[2].Text = options3[4];
                    Q5.Items[3].Text = options4[4];
                    Session["ans5"] = answers[4];
                }
                if (questions.Count >= 6)
                {
                    Label6.Text = "Q6. " + questions[5];
                    Q6.Items[0].Text = options1[5];
                    Q6.Items[1].Text = options2[5];
                    Q6.Items[2].Text = options3[5];
                    Q6.Items[3].Text = options4[5];
                    Session["ans6"] = answers[5];
                }
                if (questions.Count >= 7)
                {
                    Label7.Text = "Q7. " + questions[6];
                    Q7.Items[0].Text = options1[6];
                    Q7.Items[1].Text = options2[6];
                    Q7.Items[2].Text = options3[6];
                    Q7.Items[3].Text = options4[6];
                    Session["ans7"] = answers[6];
                }
                if (questions.Count >= 8)
                {
                    Label8.Text = "Q8. " + questions[7];
                    Q8.Items[0].Text = options1[7];
                    Q8.Items[1].Text = options2[7];
                    Q8.Items[2].Text = options3[7];
                    Q8.Items[3].Text = options4[7];
                    Session["ans8"] = answers[7];
                }
                if (questions.Count >= 9)
                {
                    Label9.Text = "Q9. " + questions[8];
                    Q9.Items[0].Text = options1[8];
                    Q9.Items[1].Text = options2[8];
                    Q9.Items[2].Text = options3[8];
                    Q9.Items[3].Text = options4[8];
                    Session["ans9"] = answers[8];
                }


                if (questions.Count >= 10)
                {
                    Label10.Text = "Q10. " + questions[9];
                    Q10.Items[0].Text = options1[9];
                    Q10.Items[1].Text = options2[9];
                    Q10.Items[2].Text = options3[9];
                    Q10.Items[3].Text = options4[9];
                    Session["ans10"] = answers[9];
                }

            }


            string uname = Session["UserName"].ToString();
            bool p1 = false;
            bool p2 = false;
            bool p3 = false; ;
            bool p4 = false;
            bool p5 = false;
            bool p6 = false;
            bool p7 = false;
            bool p8 = false;
            bool p9 = false;
            bool p10 = false;
            bool p11 = false;
            bool p12 = false;
            bool p13 = false;
            bool p14 = false;
            bool p15 = false;
            bool p16 = false;
            bool p17 = false;
            bool p18 = false;
            bool p19 = false;
            bool p20 = false;
            bool p21 = false;
            bool p22 = false;
            bool p23 = false;
            bool p24 = false;

            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string sql = "select attempt, policy_1, policy_2, policy_3, policy_4, policy_5, policy_6, policy_7, policy_8, policy_9, policy_10, policy_11, policy_12, policy_13, policy_14, policy_15, policy_16, policy_17, policy_18, policy_19, policy_20, policy_21, policy_22, policy_23, policy_24, Test_percentage from status where username='" + uname + "' and attempt = (select max(attempt) from status where username = '" + uname + "')";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                attempt = Convert.ToInt32(dr.GetValue(0));
                p1 = Convert.ToBoolean(dr.GetValue(1));
                p2 = Convert.ToBoolean(dr.GetValue(2));
                p3 = Convert.ToBoolean(dr.GetValue(3));
                p4 = Convert.ToBoolean(dr.GetValue(4));
                p5 = Convert.ToBoolean(dr.GetValue(5));
                p6 = Convert.ToBoolean(dr.GetValue(6));
                p7 = Convert.ToBoolean(dr.GetValue(7));
                p8 = Convert.ToBoolean(dr.GetValue(8));
                p9 = Convert.ToBoolean(dr.GetValue(9));
                p10 = Convert.ToBoolean(dr.GetValue(10));
                p11 = Convert.ToBoolean(dr.GetValue(11));
                p12 = Convert.ToBoolean(dr.GetValue(12));
                p13 = Convert.ToBoolean(dr.GetValue(13));
                p14 = Convert.ToBoolean(dr.GetValue(14));
                p15 = Convert.ToBoolean(dr.GetValue(15));
                p16 = Convert.ToBoolean(dr.GetValue(16));
                p17 = Convert.ToBoolean(dr.GetValue(17));
                p18 = Convert.ToBoolean(dr.GetValue(18));
                p19 = Convert.ToBoolean(dr.GetValue(19));
                p20 = Convert.ToBoolean(dr.GetValue(20));
                p21 = Convert.ToBoolean(dr.GetValue(21));
                p22 = Convert.ToBoolean(dr.GetValue(22));
                p23 = Convert.ToBoolean(dr.GetValue(23));
                p24 = Convert.ToBoolean(dr.GetValue(24));
                per = Convert.ToInt32(dr.GetValue(25));
            }

            con.Close();

            attempt = attempt + 1;

            if (p1 == true && p2 == true && p3 == true && p4 == true && p5 == true && p6 == true && p7 == true && p8 == true && p9 == true && p10 == true && p11 == true && p12 == true && p13 == true && p14 == true && p15 == true && p16 == true && p17 == true && p18 == true && p19 == true && p20 == true && p21 == true && p22 == true && p23 == true && p24 == true)
            {

                if (attempt == 1)
                {
                    Q1.Visible = false;
                    Q2.Visible = false;
                    Q3.Visible = false;
                    Q4.Visible = false;
                    Q5.Visible = false;
                    Q6.Visible = false;
                    Q7.Visible = false;
                    Q8.Visible = false;
                    Q9.Visible = false;
                    Q10.Visible = false;
                    result.Visible = false;
                    Label1.Visible = false;
                    Label2.Visible = false;
                    Label3.Visible = false;
                    Label4.Visible = false;
                    Label5.Visible = false;
                    Label6.Visible = false;
                    Label7.Visible = false;
                    Label8.Visible = false;
                    Label9.Visible = false;
                    Label10.Visible = false;
                    result.Visible = false;
                    Button1.Visible = false;
                    Button2.Visible = true;
                    Note.Text = "I've read all the policies and ready to proceed further! ";
                    Att.Visible = false;
                }

                else if (attempt > 1)
 {
                    Q1.Visible = true;
                    Q2.Visible = true;
                    Q3.Visible = true;
                    Q4.Visible = true;
                    Q5.Visible = true;
                    Q6.Visible = true;
                    Q7.Visible = true;
                    Q8.Visible = true;
                    Q9.Visible = true;
                    Q10.Visible = true;
                    Label1.Visible = true;
                    Label2.Visible = true;
                    Label3.Visible = true;
                    Label4.Visible = true;
                    Label5.Visible = true;
                    Label6.Visible = true;
                    Label7.Visible = true;
                    Label8.Visible = true;
                    Label9.Visible = true;
                    Label10.Visible = true;
                    result.Visible = true;
                    Button1.Visible = true;
                    Att.Visible = true;
                    result.Visible = true;
                    Button1.Visible = true;
                    Button2.Visible = false;
                    Note.Text = "Note: Please complete the quiz in single attempt.";
                    Att.Text = "No. of attempt: " + attempt.ToString();
                }

            }

            else if (p1 == false || p2 == false || p3 == false || p4 == false || p5 == false || p6 == false || p7 == false || p8 == false || p9 == false || p10 == false || p11 == false || p12 == false || p13 == false || p14 == false || p15 == false || p16 == false || p17 == false || p18 == false || p19 == false || p20 == false || p21 == false || p22 == false || p23 == false || p24 == false)
            {
                Q1.Visible = false;
                Q2.Visible = false;
                Q3.Visible = false;
                Q4.Visible = false;
                Q5.Visible = false;
                Q6.Visible = false;
                Q7.Visible = false;
                Q8.Visible = false;
                Q9.Visible = false;
                Q10.Visible = false;
                Label1.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label8.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                result.Text = "";
                Button2.Visible = false;
                Button1.Visible = false;
                Att.Visible = false;
                Note.Text = "Note: You're not eligible for the quiz (Please download all the policies to mark your acceptance).";
            }

            if (per >= 60)
            {
                Q1.Visible = false;
                Q2.Visible = false;
                Q3.Visible = false;
                Q4.Visible = false;
                Q5.Visible = false;
                Q6.Visible = false;
                Q7.Visible = false;
                Q8.Visible = false;
                Q9.Visible = false;
                Q10.Visible = false;
                Label1.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label8.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                result.Text = "";
                Button2.Visible = false;
                Button1.Visible = false;
                Att.Visible = false;
                Note.Text = "Note: You have already completed the quiz successfully with 60% or more marks.";
            }
        }


        protected void CalculateScore()
        {

            string ans1 = Session["ans1"] as string;
            string ans2 = Session["ans2"] as string;

            string ans3 = Session["ans3"] as string;
            string ans4 = Session["ans4"] as string;

            string ans5 = Session["ans5"] as string;
            string ans6 = Session["ans6"] as string;

            string ans7 = Session["ans7"] as string;
            string ans8 = Session["ans8"] as string;

            string ans9 = Session["ans9"] as string;
            string ans10 = Session["ans10"] as string;

            // Implement your logic to calculate the quiz score here.
            int score = 0;
            if (Q1.SelectedItem.Text == ans1)
                score += 10;
            if (Q2.SelectedItem.Text == ans2)
                score += 10;
            if (Q3.SelectedItem.Text == ans3)
                score += 10;
            if (Q4.SelectedItem.Text == ans4)
                score += 10;
            if (Q5.SelectedItem.Text == ans5)
                score += 10;
            if (Q6.SelectedItem.Text == ans6)
                score += 10;
            if (Q7.SelectedItem.Text == ans7)
                score += 10;
            if (Q8.SelectedItem.Text == ans8)
                score += 10;
            if (Q9.SelectedItem.Text == ans9)
                score += 10;
            if (Q10.SelectedItem.Text == ans10)
                score += 10;

            result.Text = "Quiz Percentage = " + score.ToString() + "%";


            if (attempt == 1)
            {
                string uname = Session["UserName"].ToString();
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                string query = "update status set attempt = '" + attempt + "', Test_percentage = '" + score + "', date = GETDATE() where username = '" + uname + "' and attempt = (select max(attempt) from status where username = '" + uname + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            
            }

            else if (attempt > 1)
            {

                string uname = Session["UserName"].ToString();
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                string query = "insert into status (username, attempt, policy_1, policy_2, policy_3, policy_4, policy_5, policy_6, policy_7, policy_8, policy_9, policy_10, policy_11, policy_12, policy_13, policy_14, policy_15, policy_16, policy_17, policy_18, policy_19, policy_20, policy_21, policy_22, policy_23, policy_24, Test_percentage, read_mark, date) values ('" + uname + "','" + attempt + "', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, '" + score + "', 1, GETDATE())";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
             
            }




            Button1.Visible = false;
            Q1.Enabled = false;
            Q2.Enabled = false;
            Q3.Enabled = false;
            Q4.Enabled = false;
            Q5.Enabled = false;
            Q6.Enabled = false;
            Q7.Enabled = false;
            Q8.Enabled = false;
            Q9.Enabled = false;
            Q10.Enabled = false;

            Response.Redirect("/ThankyouForm.aspx");


        }


        public class QuestionLists
        {
            public List<string> List1 { get; set; }
            public List<string> List2 { get; set; }
            public List<string> List3 { get; set; }
            public List<string> List4 { get; set; }
            public List<string> List5 { get; set; }
            public List<string> List6 { get; set; }

        }

        private QuestionLists GetQuestionsFromDatabase()
        {

            List<string> questions = new List<string>();
            List<string> options1 = new List<string>();
            List<string> options2 = new List<string>();
            List<string> options3 = new List<string>();
            List<string> options4 = new List<string>();
            List<string> answers = new List<string>();


            string connectionString = @"Data Source=crmtest; Initial Catalog=policy_db; User ID=t_graduate;Password=Oracle_123";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Replace with your SQL query to retrieve questions from the database
                string sqlQuery = "SELECT TOP 10 Question,A,B,C,D,Answer FROM POLICY_QUESTIONS ORDER BY NEWID()";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Read each question text from the database
                            questions.Add(reader["Question"].ToString());
                            options1.Add(reader["A"].ToString());
                            options2.Add(reader["B"].ToString());
                            options3.Add(reader["C"].ToString());
                            options4.Add(reader["D"].ToString());
                            answers.Add(reader["Answer"].ToString());

                        }

                    }

                    connection.Close();
                }



            }
            // Return the lists as a tuple
            return new QuestionLists
            {
                List1 = questions,
                List2 = options1,
                List3 = options2,
                List4 = options3,
                List5 = options4,
                List6 = answers,
            };
        }

        protected void condition(object sender, EventArgs e)
        {
            // Check if the user has selected answers for each question
            if (IsAnswerSelected(Q1) && IsAnswerSelected(Q2) && IsAnswerSelected(Q3) && IsAnswerSelected(Q4) && IsAnswerSelected(Q5)
                && IsAnswerSelected(Q6) && IsAnswerSelected(Q7) && IsAnswerSelected(Q8) && IsAnswerSelected(Q9) && IsAnswerSelected(Q10))
            {
                // Process the submitted answers (e.g., calculate score)
                CalculateScore();


                // You can also redirect the user to a results page or display their score.
            }
            else
            {
                // Display a message indicating that all questions must be answered.
                Q1.Visible = true;
                Q2.Visible = true;
                Q3.Visible = true;
                Q4.Visible = true;
                Q5.Visible = true;
                Q6.Visible = true;
                Q7.Visible = true;
                Q8.Visible = true;
                Q9.Visible = true;
                Q10.Visible = true;
                Label1.Visible = true;
                Label2.Visible = true;
                Label3.Visible = true;
                Label4.Visible = true;
                Label5.Visible = true;
                Label6.Visible = true;
                Label7.Visible = true;
                Label8.Visible = true;
                Label9.Visible = true;
                Label10.Visible = true;
                result.Visible = true;
                Att.Visible = true;
                result.Visible = true;
                Button1.Visible = true;
                Button2.Visible = false;
                Note.Text = "Note: Please complete the quiz in single attempt.";
                Att.Text = "No. of attempt: " + attempt.ToString();
                result.Text = "Please Answer All Questions";
            }
        }

        private bool IsAnswerSelected(RadioButtonList rbl)
        {
            // Check if at least one item is selected in the RadioButtonList
            return rbl.SelectedItem != null;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            string uname = Session["UserName"].ToString();
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "update status set read_mark = 1 where username = '" + uname + "' and attempt = (select max(attempt) from status where username = '" + uname + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            Q1.Visible = true;
            Q2.Visible = true;
            Q3.Visible = true;
            Q4.Visible = true;
            Q5.Visible = true;
            Q6.Visible = true;
            Q7.Visible = true;
            Q8.Visible = true;
            Q9.Visible = true;
            Q10.Visible = true;
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
            Label5.Visible = true;
            Label6.Visible = true;
            Label7.Visible = true;
            Label8.Visible = true;
            Label9.Visible = true;
            Label10.Visible = true;
            result.Visible = true;
            Att.Visible = true;
            result.Visible = true;
            Button1.Visible = true;
            Button2.Visible = false;
            Note.Text = "Note: Please complete the quiz in single attempt.";
            Att.Text = "No. of attempt: " + attempt.ToString();
        }
    }
}