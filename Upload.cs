using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace RateApp
{
    public partial class Upload : Form
    {
        public Upload()
        {
            InitializeComponent();
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
        }

        private void cmdUpload_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFilePath.Text != "")
                {
                    string fileName = txtFilePath.Text;

                    DataTable sheetData = new DataTable();
                    using (OleDbConnection conn = this.returnConnection(fileName))
                    {
                        conn.Open();
                        OleDbDataAdapter sheetAdapter = new OleDbDataAdapter("select top 30000 * from [Sheet1$]", conn);
                        sheetAdapter.Fill(sheetData);
                        conn.Close();
                    }

                    int nCount = 0;
                    //string truncateQry = "truncate table award_publication ";

                    string insertQry = "INSERT INTO [award_publication] ([Pricing Rate ID], [SORT (Edited)], [Sent To Publish], " +
                        " [Has Been Published], [Rate Number], [Company], [Customer Acknowledgement], [Source], [Parent Customer], " +
                        " [Customer BT], [Cust Lane ID], [Rate Type], [Origin City], [Origin State], [Origin Zip], [Origin Zip Range], " +
                        " [Dest City], [Dest State], [Dest Zip], [Dest Zip Range], [Award Type], [Awarded Vol], [Awarded Freq], " +
                        " [Award_Type], [Award RPM], [Award MIN], [Award Flat], [Rate Tyle], [Effective Date], [Expiration Date], " +
                        " [Origin Load Type], [Dest Unload Type], [Equipment Type], [Pricing Contact], [Pricing Change], [Comment]) " +
                        " VALUES (@pricingRateId, @sortId, @sentPub, @hasPub, @rateNum, @company, @custAck, " +
                        " @source, @parentCust, @customer, @custLaneId, @rateType, @originCity, @originState, " +
                        " @originZip, @originZipRange, @destCity, @destState, @destZip, @destZipRange, @awardType, " +
                        " @awardVol, @awardFreq, @awardType2, @awardRpm, @awardMin, @awardFlat, @rateTyle, @effDate, @expDate, " +
                        " @orgLoadType, @destUnloadType, @equipType, @pricingContact, @pricingChange, @comment )";
                        
                    string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

                    using (SqlConnection con = new SqlConnection(connStr))
                    {
                        if (sheetData.Rows.Count > 0)
                        {
                            //SqlCommand cmd2 = new SqlCommand(truncateQry, con);
                            //con.Open();
                            //cmd2.ExecuteNonQuery();
                            //con.Close();

                            foreach (DataRow row in sheetData.Rows)
                            {
                                string pricingRateId = row[0].ToString();
                                string sortId = row[1].ToString();
                                string sentPub = row[2].ToString();
                                string hasPub = row[3].ToString();
                                string rateNum = row[4].ToString();
                                string company = row[5].ToString();
                                string custAck = row[6].ToString();
                                string source = row[7].ToString();
                                string parentCust = row[8].ToString();
                                string customer = row[9].ToString();
                                string custLaneId = row[10].ToString();
                                string rateType = row[11].ToString();
                                string originCity = row[12].ToString();
                                string originState = row[13].ToString();
                                string originZip = row[14].ToString();
                                string originZipRange = row[15].ToString();
                                string destCity = row[16].ToString();
                                string destState = row[17].ToString();
                                string destZip = row[18].ToString();
                                string destZipRange = row[19].ToString();
                                string awardType = row[20].ToString();
                                string awardVol = row[21].ToString();
                                string awardFreq = row[22].ToString();
                                string awardType2 = row[23].ToString();
                                string awardRPM = row[24].ToString();
                                string awardMIN = row[25].ToString();
                                string awardFlat = row[26].ToString();
                                string rateTyle = row[27].ToString();
                                string effDate = row[28].ToString();
                                string expDate = row[29].ToString();
                                string orgLoadType = row[30].ToString();
                                string destUnloadType = row[31].ToString();
                                string equipType = row[32].ToString();
                                string pricingContact = row[33].ToString();
                                string pricingChange = row[34].ToString();
                                string changed = row[35].ToString();
                                string comment = row[36].ToString();

                                if (pricingRateId != "" && pricingRateId != null)
                                {
                                    if (changed != "")
                                    {
                                        nCount += 1;
                                        if (originZipRange.Contains("-") || originZipRange.Contains(":") || originZipRange.Contains(","))
                                        {
                                            List<string> sZips = getZips(originZipRange);
                                            if (sZips.Count > 0)
                                            {
                                                originZipRange = string.Join(", ", sZips.ToArray());
                                            }
                                        }

                                        if (destZipRange.Contains("-") || destZipRange.Contains(":") || destZipRange.Contains(","))
                                        {
                                            List<string> sZips = getZips(destZipRange);
                                            if (sZips.Count > 0)
                                            {
                                                destZipRange = string.Join(", ", sZips.ToArray());
                                            }
                                        }

                                        string deleteQry = "DELETE [award_publication] WHERE [Pricing Rate ID] = '" + pricingRateId + "'";

                                        switch (changed)
                                        {
                                            case "A":

                                                using (SqlCommand command = new SqlCommand(insertQry, con))
                                                {
                                                    con.Open();
                                                    command.Parameters.AddWithValue("@pricingRateId", pricingRateId);
                                                    command.Parameters.AddWithValue("@sortId", sortId);
                                                    command.Parameters.AddWithValue("@sentPub", sentPub);
                                                    command.Parameters.AddWithValue("@hasPub", hasPub);
                                                    command.Parameters.AddWithValue("@rateNum", rateNum);
                                                    command.Parameters.AddWithValue("@company", company);
                                                    command.Parameters.AddWithValue("@custAck", custAck);
                                                    command.Parameters.AddWithValue("@source", source);
                                                    command.Parameters.AddWithValue("@parentCust", parentCust);
                                                    command.Parameters.AddWithValue("@customer", customer);
                                                    command.Parameters.AddWithValue("@custLaneId", custLaneId);
                                                    command.Parameters.AddWithValue("@rateType", rateType);
                                                    command.Parameters.AddWithValue("@originCity", originCity);
                                                    command.Parameters.AddWithValue("@originState", originState);
                                                    command.Parameters.AddWithValue("@originZip", originZip);
                                                    command.Parameters.AddWithValue("@originZipRange", originZipRange);
                                                    command.Parameters.AddWithValue("@destCity", destCity);
                                                    command.Parameters.AddWithValue("@destState", destState);
                                                    command.Parameters.AddWithValue("@destZip", destZip);
                                                    command.Parameters.AddWithValue("@destZipRange", destZipRange);
                                                    command.Parameters.AddWithValue("@awardType", awardType);
                                                    command.Parameters.AddWithValue("@awardVol", awardVol);
                                                    command.Parameters.AddWithValue("@awardFreq", awardFreq);
                                                    command.Parameters.AddWithValue("@awardType2", awardType2);
                                                    command.Parameters.AddWithValue("@awardRPM", awardRPM);
                                                    command.Parameters.AddWithValue("@awardMIN", awardMIN);
                                                    command.Parameters.AddWithValue("@awardFlat", awardFlat);
                                                    command.Parameters.AddWithValue("@rateTyle", rateTyle);
                                                    command.Parameters.AddWithValue("@effDate", effDate);
                                                    command.Parameters.AddWithValue("@expDate", expDate);
                                                    command.Parameters.AddWithValue("@orgLoadType", orgLoadType);
                                                    command.Parameters.AddWithValue("@destUnloadType", destUnloadType);
                                                    command.Parameters.AddWithValue("@equipType", equipType);
                                                    command.Parameters.AddWithValue("@pricingContact", pricingContact);
                                                    command.Parameters.AddWithValue("@pricingChange", pricingChange);
                                                    command.Parameters.AddWithValue("@comment", comment);
                                                    command.ExecuteNonQuery();
                                                }
                                                    break;
                                            case "C":

                                                //delete old record
                                                SqlCommand cmd = new SqlCommand(deleteQry, con);
                                                con.Open();
                                                cmd.ExecuteNonQuery();
                                                //con.Close();

                                                using (SqlCommand command = new SqlCommand(insertQry, con))
                                                {
                                                    //con.Open();
                                                    command.Parameters.AddWithValue("@pricingRateId", pricingRateId);
                                                    command.Parameters.AddWithValue("@sortId", sortId);
                                                    command.Parameters.AddWithValue("@sentPub", sentPub);
                                                    command.Parameters.AddWithValue("@hasPub", hasPub);
                                                    command.Parameters.AddWithValue("@rateNum", rateNum);
                                                    command.Parameters.AddWithValue("@company", company);
                                                    command.Parameters.AddWithValue("@custAck", custAck);
                                                    command.Parameters.AddWithValue("@source", source);
                                                    command.Parameters.AddWithValue("@parentCust", parentCust);
                                                    command.Parameters.AddWithValue("@customer", customer);
                                                    command.Parameters.AddWithValue("@custLaneId", custLaneId);
                                                    command.Parameters.AddWithValue("@rateType", rateType);
                                                    command.Parameters.AddWithValue("@originCity", originCity);
                                                    command.Parameters.AddWithValue("@originState", originState);
                                                    command.Parameters.AddWithValue("@originZip", originZip);
                                                    command.Parameters.AddWithValue("@originZipRange", originZipRange);
                                                    command.Parameters.AddWithValue("@destCity", destCity);
                                                    command.Parameters.AddWithValue("@destState", destState);
                                                    command.Parameters.AddWithValue("@destZip", destZip);
                                                    command.Parameters.AddWithValue("@destZipRange", destZipRange);
                                                    command.Parameters.AddWithValue("@awardType", awardType);
                                                    command.Parameters.AddWithValue("@awardVol", awardVol);
                                                    command.Parameters.AddWithValue("@awardFreq", awardFreq);
                                                    command.Parameters.AddWithValue("@awardType2", awardType2);
                                                    command.Parameters.AddWithValue("@awardRPM", awardRPM);
                                                    command.Parameters.AddWithValue("@awardMIN", awardMIN);
                                                    command.Parameters.AddWithValue("@awardFlat", awardFlat);
                                                    command.Parameters.AddWithValue("@rateTyle", rateTyle);
                                                    command.Parameters.AddWithValue("@effDate", effDate);
                                                    command.Parameters.AddWithValue("@expDate", expDate);
                                                    command.Parameters.AddWithValue("@orgLoadType", orgLoadType);
                                                    command.Parameters.AddWithValue("@destUnloadType", destUnloadType);
                                                    command.Parameters.AddWithValue("@equipType", equipType);
                                                    command.Parameters.AddWithValue("@pricingContact", pricingContact);
                                                    command.Parameters.AddWithValue("@pricingChange", pricingChange);
                                                    command.Parameters.AddWithValue("@comment", comment);
                                                    command.ExecuteNonQuery();
                                                }

                                                break;

                                            case "D":
                                                SqlCommand cmdDelete = new SqlCommand(deleteQry, con);
                                                con.Open();
                                                cmdDelete.ExecuteNonQuery();
                                                break;

                                            default:

                                                break;

                                        }
                                    }
                                    
                                    con.Close();
                                }
                            }
                        }
                    }

                    lblResults.Text = nCount.ToString() + " records uploaded successfully.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private OleDbConnection returnConnection(string fileName)
        {
            //return new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + "; Jet OLEDB:Engine Type=5;Extended Properties=\"Excel 8.0;\"");
            return new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties=Excel 12.0;");

        }

        private static List<string> getZips(string sZips)
        {

            var zipList = new List<string>();
            try
            {


                var nLen = sZips.Length;

                var nCount = 0;

                sZips = sZips.Replace(" ", "");

                while (nLen > 3)
                {
                    string sChar = sZips.Substring(nCount, 1);
                    string sFirst = sZips.Substring(nCount, 3);
                    string sSecond = sZips.Substring(nCount + 1, 1);
                    string sCheck = sZips.Substring(nCount + 3, 1);

                    if (nLen > 3)
                    {
                        if (sChar == ",")
                        {
                            sFirst = sZips.Substring(nCount + 1, 3);

                            if (nLen >= 7)
                            {
                                sCheck = sZips.Substring(nCount + 4, 1);

                                if (sCheck == "-" || sCheck == ":")
                                {

                                    string sRange = sZips.Substring(nCount + 1, 7);

                                    int firstno = Convert.ToInt32(sRange.Substring(0, 3));
                                    int lastno = Convert.ToInt32(sRange.Substring(4, 3));

                                    int count = (lastno - firstno) + 1;

                                    var x = new List<string>();
                                    foreach (int i in Enumerable.Range(firstno, count)) x.Add(i.ToString());

                                    zipList.AddRange(x);
                                    nLen -= 8;
                                    nCount += 7;

                                }
                                else if (sSecond == " ")
                                {

                                    string sRange = sZips.Substring(nCount, 6);


                                    int firstno = Convert.ToInt32(sRange.Substring(0, 3));
                                    int lastno = Convert.ToInt32(sRange.Substring(4, 3));

                                    int count = (lastno - firstno) + 1;

                                    var x = new List<string>();
                                    foreach (int i in Enumerable.Range(firstno, count)) x.Add(i.ToString());

                                    zipList.AddRange(x);
                                    nLen -= 7;
                                    nCount += 7;

                                }
                                else
                                {
                                    nLen -= 3;
                                    nCount += 4;

                                    zipList.Add(sFirst);
                                }

                            }
                            else
                            {
                                nLen -= 3;
                                nCount += 3;

                                zipList.Add(sFirst);
                            }
                        }
                        else if (sZips.Substring(nCount + 3, 1) == ",")
                        {
                            nLen -= 3;
                            nCount += 3;

                            zipList.Add(sFirst);

                        }
                        else if (sCheck == "-" || sCheck == ":")
                        {

                            string sRange = sZips.Substring(nCount, 7);

                            int firstno = Convert.ToInt32(sRange.Substring(0, 3));
                            int lastno = Convert.ToInt32(sRange.Substring(4, 3));

                            int count = (lastno - firstno) + 1;

                            var x = new List<string>();
                            foreach (int i in Enumerable.Range(firstno, count)) x.Add(i.ToString());

                            zipList.AddRange(x);
                            nLen -= 7;
                            nCount += 7;

                        }
                        else
                        {
                            if (nLen == 5)
                            {
                                zipList.Add(sZips.Substring(nCount, 5));

                                nLen -= 5;
                            }
                            else if (nLen == 6)
                            {
                                string sFirstZip = sZips.Substring(nCount, 3);
                                string sSecondZip = sZips.Substring(nCount + 3, 3);

                                zipList.Add(sFirstZip);
                                zipList.Add(sSecondZip);
                                nLen -= 6;
                            }
                            else if (nLen == 4)
                            {
                                string sFour = sZips.Substring(nCount + 1, 4);

                                sFour = sFour.Replace(",", "");

                                zipList.Add(sFour);
                                nLen -= 4;

                            }
                            else
                            {
                                break;

                            }




                        }
                    }

                }

                for (int i = 0; i < zipList.Count; i++)
                {
                    string sTest = zipList[i].Trim();

                    if (sTest.Length < 3)
                    {

                        zipList[i] = zipList[i].Replace(zipList[i].ToString(), "0" + zipList[i].Trim());
                    }

                }

                return zipList;

            }
            catch (Exception)
            {

                return zipList;
            }
            finally
            {


            }
        }

        private void ofd_FileOk(object sender, CancelEventArgs e)
        {
            txtFilePath.Text = ofd.FileName;
        }

        private void cmdCleanUp_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

                string dupQuery = "SELECT Count([Pricing Rate ID]) As Duplicates, [Customer BT], [Origin City], [Origin State], [Origin Zip], " +
                     " [Origin Zip Range], [Dest City], [Dest State], [Dest Zip], [Dest Zip Range]  From award_publication_temp " +
                     " WHERE (GETDATE() BETWEEN ISNULL([Effective Date], GETDATE()) AND ISNULL([Expiration Date], GETDATE())) " +
                     " GROUP BY [Customer BT], [Origin City], [Origin State], [Origin Zip], " +
                     " [Origin Zip Range], [Dest City], [Dest State], [Dest Zip], [Dest Zip Range] " +
                     " ORDER BY Duplicates DESC";

                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(dupQuery, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                conn.Open();

                da.Fill(dt);

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        int dups = int.Parse(row[0].ToString());

                        if (dups > 1)
                        {
                            AwardsData ad = new AwardsData();

                            ad.Customer = row["Customer BT"].ToString();
                            ad.OriginCity = row["Origin City"].ToString();
                            ad.OriginState = row["Origin State"].ToString();
                            ad.OriginZip = row["Origin Zip"].ToString();
                            ad.OriginZipRange = row["Origin Zip Range"].ToString();
                            ad.DestCity = row["Dest City"].ToString();
                            ad.DestState = row["Dest State"].ToString();
                            ad.DestZip = row["Dest Zip"].ToString();
                            ad.DestZipRange = row["Dest Zip Range"].ToString();

                            string query = "SELECT [Pricing Rate ID] FROM award_publication_temp WHERE [Customer BT] = @customer " +
                                " AND [Origin City] = @originCity AND [Origin State] = @originState AND [Origin Zip] = @originZip " +
                                " AND [Origin Zip Range] = @originZipRange AND [Dest City] = @destCity AND [Dest State] = @destState " +
                                " AND [Dest Zip] = @destZip AND [Dest Zip Range] = @destZipRange " +
                                " ORDER BY [Pricing Rate ID] DESC ";


                            using (SqlCommand command = new SqlCommand(query, conn))
                            {

                                using (SqlDataAdapter sda = new SqlDataAdapter(command))
                                {
                                    command.Parameters.AddWithValue("@customer", ad.Customer);
                                    command.Parameters.AddWithValue("@originCity", ad.OriginCity);
                                    command.Parameters.AddWithValue("@originState", ad.OriginState);
                                    command.Parameters.AddWithValue("@originZip", ad.OriginZip);
                                    command.Parameters.AddWithValue("@originZipRange", ad.OriginZipRange);
                                    command.Parameters.AddWithValue("@destCity", ad.DestCity);
                                    command.Parameters.AddWithValue("@destState", ad.DestState);
                                    command.Parameters.AddWithValue("@destZip", ad.DestZip);
                                    command.Parameters.AddWithValue("@destZipRange", ad.DestZipRange);

                                    DataTable dtDups = new DataTable();

                                    sda.Fill(dtDups);

                                    int nCount = 0;

                                    if (dtDups != null && dtDups.Rows.Count > 0)
                                    {
                                        foreach (DataRow dupRow in dtDups.Rows)
                                        {
                                            if (nCount > 0)
                                            {
                                                string pricingRateId = dupRow["Pricing Rate ID"].ToString();
                                                string deleteQry = "DELETE award_publication_temp WHERE [Pricing Rate ID] = '" + pricingRateId + "'";

                                                SqlCommand deleteCmd = new SqlCommand(deleteQry, conn);

                                                deleteCmd.ExecuteNonQuery();

                                            }

                                            nCount += 1;

                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public class AwardsData
        {
            public string PricingRateId { get; set; }
            public string Customer { get; set; }
            public string CsrId { get; set; }
            public string SalesPersonId { get; set; }
            public string OriginZipRange { get; set; }
            public string OriginCity { get; set; }
            public string OriginState { get; set; }
            public string OriginZip { get; set; }
            public string DestZipRange { get; set; }
            public string DestCity { get; set; }
            public string DestState { get; set; }
            public string DestZip { get; set; }
            public int Loads { get; set; }
            public decimal AvgProfit { get; set; }
            public string AwardVol { get; set; }
            public string AwardFreq { get; set; }
            public string AwardRPM { get; set; }
            public string AwardMIN { get; set; }
            public string AwardFlat { get; set; }
            public string RateType { get; set; }
            public DateTime EffectiveDate { get; set; }
            public DateTime ExpirationDate { get; set; }
            public string EquipmentType { get; set; }
            public string AwardType { get; set; }
            public string AwardType2 { get; set; }
            public string RateType2 { get; set; }
            public string Company { get; set; }
            public string Comment { get; set; }
            public string ParentCustomer { get; set; }
            public string RateNumber { get; set; }
            public string CustLaneId { get; set; }

        }

    }
}
