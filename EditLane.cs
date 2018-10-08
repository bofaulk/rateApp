using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace RateApp
{
    public partial class EditLane : Form
    {

        public string PricingRateID { get; set; }
        public bool NewRecord { get; set; }

        public EditLane(string pricingRateId)
        {
            InitializeComponent();
            PricingRateID = pricingRateId;
            buildForm();
        }

        //public void NewRecord()
        //{
        //    txtPricingRateID.ReadOnly = false;
        //}

        private void buildForm()
        {
            try
            {
                if (PricingRateID != "")
                {
                    NewRecord = false;
                    loadRecord();
                }
                else
                {
                    NewRecord = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void loadRecord()
        {

            try
            {
                txtPricingRateID.Text = PricingRateID;
                txtPricingRateID.ReadOnly = true;

                string query = "SELECT [Customer BT], [Origin City], [Origin State], [Company], [Origin Zip], [Origin Zip Range], " +
                    " [Dest City], [Dest State], [Dest Zip], [Dest Zip Range], [Awarded Vol], [Award Type], [Awarded Freq], " +
                    " [Awarded Freq], [Award RPM], [Award MIN], [Award Flat], [Rate Type], [Rate Number], [Equipment Type], " +
                    " [RATE_TYPE], [Cust Lane ID], [Award_Type], [Company], [Parent Customer], [Comment], [Pricing Contact], [Pricing Change], " +
                    "CONVERT(VARCHAR(10),[Effective Date],101) AS [Effective Date], CONVERT(VARCHAR(10),[Expiration Date],101) AS [Expiration Date] " +
                    " FROM AwardedLanes WHERE [Pricing Rate ID] =  '" + PricingRateID + "' ";

                string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

                using (SqlConnection con = new SqlConnection(connStr))
                {
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        con.Open();

                        using (SqlDataAdapter sda = new SqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            if (dt != null && dt.Rows.Count > 0)
                            {
                                txtCustomer.Text = dt.Rows[0]["Customer BT"].ToString();
                                txtParentCustomer.Text = dt.Rows[0]["Parent Customer"].ToString();
                                txtEffDate.Text = dt.Rows[0]["Effective Date"].ToString();
                                txtExpDate.Text = dt.Rows[0]["Expiration Date"].ToString();
                                txtOriginCity.Text = dt.Rows[0]["Origin City"].ToString();
                                txtOriginState.Text = dt.Rows[0]["Origin State"].ToString();
                                txtOriginZip.Text = dt.Rows[0]["Origin Zip"].ToString();
                                txtOriginZipRange.Text = dt.Rows[0]["Origin Zip Range"].ToString();
                                txtDestCity.Text = dt.Rows[0]["Dest City"].ToString();
                                txtDestState.Text = dt.Rows[0]["Dest State"].ToString();
                                txtDestZip.Text = dt.Rows[0]["Dest Zip"].ToString();
                                txtDestZipRange.Text = dt.Rows[0]["Dest Zip Range"].ToString();
                                txtAwardType.Text = dt.Rows[0]["Award_Type"].ToString();
                                txtAwardTypePS.Text = dt.Rows[0]["Award Type"].ToString();
                                txtAwardFreq.Text = dt.Rows[0]["Awarded Freq"].ToString();
                                txtAwardedVol.Text = dt.Rows[0]["Awarded Vol"].ToString();
                                txtAwardRPM.Text = dt.Rows[0]["Award RPM"].ToString();
                                txtAwardMIN.Text = dt.Rows[0]["Award MIN"].ToString();
                                txtAwardFlat.Text = dt.Rows[0]["Award Flat"].ToString();
                                txtRateType.Text = dt.Rows[0]["RATE_TYPE"].ToString();
                                txtRateNumber.Text = dt.Rows[0]["Rate Number"].ToString();
                                txtEquipType.Text = dt.Rows[0]["Equipment Type"].ToString();
                                txtRateTypeFSC.Text = dt.Rows[0]["Rate Type"].ToString();
                                txtPricingContact.Text = dt.Rows[0]["Pricing Change"].ToString();
                                txtPricingChange.Text = dt.Rows[0]["Pricing Contact"].ToString();
                                txtComment.Text = dt.Rows[0]["Comment"].ToString();
                                txtCompany.Text = dt.Rows[0]["Company"].ToString();
                                txtCustLaneId.Text = dt.Rows[0]["Cust Lane ID"].ToString();

                            }
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (NewRecord)
                {
                    if (txtPricingRateID.Text != "")
                    {
                        addRecord();
                    }
                    else
                    {
                        txtPricingRateID.BackColor = Color.Khaki;
                        MessageBox.Show("Please enter a Pricing Rate ID to save this record.");
                    }
                }
                else
                {
                    updateRecord();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void addRecord()
        {

            try
            {
                string query = "INSERT INTO award_publication ([Pricing Rate ID], [Rate Number], [Company], [Parent Customer], [Customer BT], [Rate Type], " +
                    " [Origin City], [Origin State], [Origin Zip], [Origin Zip Range], [Dest City], [Dest State], [Dest Zip], [Dest Zip Range], " +
                    " [Award Type], [Awarded Vol], [Awarded Freq], [Award_Type], [Award RPM], [Award MIN], [Award Flat], [Rate Tyle], " +
                    " [Effective Date], [Expiration Date], [Equipment Type], [Pricing Contact], [Pricing Change], [Comment], [Cust Lane ID]) " +
                    " VALUES (@pricingRateId, @rateNum, @company, @parentCustomer, @customer, @rateType, @originCity, @originState, @originZip, " +
                    " @originZipRange, @destCity, @destState, @destZip, @destZipRange, @awardTypePS, @awardedVol, @awardFreq, @awardType, @awardRPM, @awardMIN, @awardFlat, " +
                    " @rateTypeFSC, @effDate, @expDate, @equipType, @pricingContact, @pricingChange, @comment, @custLaneId) ";


                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@pricingRateId", txtPricingRateID.Text);
                cmd.Parameters.AddWithValue("@rateNum", txtRateNumber.Text);
                cmd.Parameters.AddWithValue("@company", txtCompany.Text);
                cmd.Parameters.AddWithValue("@parentCustomer", txtParentCustomer.Text);
                cmd.Parameters.AddWithValue("@customer", txtCustomer.Text);
                cmd.Parameters.AddWithValue("@rateType", txtRateType.Text);
                cmd.Parameters.AddWithValue("@originCity", txtOriginCity.Text);
                cmd.Parameters.AddWithValue("@originState", txtOriginState.Text);
                cmd.Parameters.AddWithValue("@originZip", txtOriginZip.Text);
                cmd.Parameters.AddWithValue("@originZipRange", txtOriginZipRange.Text);
                cmd.Parameters.AddWithValue("@destCity", txtDestCity.Text);
                cmd.Parameters.AddWithValue("@destState", txtDestState.Text);
                cmd.Parameters.AddWithValue("@destZip", txtDestZip.Text);
                cmd.Parameters.AddWithValue("@destZipRange", txtDestZipRange.Text);
                cmd.Parameters.AddWithValue("@awardTypePS", txtAwardTypePS.Text);
                cmd.Parameters.AddWithValue("@awardedVol", txtAwardedVol.Text);
                cmd.Parameters.AddWithValue("@awardFreq", txtAwardFreq.Text);
                cmd.Parameters.AddWithValue("@awardType", txtAwardType.Text);
                cmd.Parameters.AddWithValue("@awardRPM", txtAwardRPM.Text);
                cmd.Parameters.AddWithValue("@awardMIN", txtAwardMIN.Text);
                cmd.Parameters.AddWithValue("@awardFlat", txtAwardFlat.Text);
                cmd.Parameters.AddWithValue("@rateTypeFSC", txtRateTypeFSC.Text);
                cmd.Parameters.AddWithValue("@effDate", txtEffDate.Text);
                cmd.Parameters.AddWithValue("@expDate", txtExpDate.Text);
                cmd.Parameters.AddWithValue("@equipType", txtEquipType.Text);
                cmd.Parameters.AddWithValue("@pricingContact", txtPricingContact.Text);
                cmd.Parameters.AddWithValue("@pricingChange", txtPricingChange.Text);
                cmd.Parameters.AddWithValue("@comment", txtComment.Text);
                cmd.Parameters.AddWithValue("@custLaneId", txtCustLaneId.Text);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Record added successfully.");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateRecord()
        {

            try
            {
                string query = "UPDATE award_publication SET [Customer BT] = @customer, [Parent Customer] = @parentCustomer, [Company] = @company, " +
                    " [Rate Type] = @rateType, [Origin City] = @originCity, [Origin State] = @originState, [Origin Zip] = @originZip,  " +
                    " [Origin Zip Range] = @originZipRange, [Dest City] = @destCity, [Dest State] = @destState, [Dest Zip] = @destZip, " +
                    " [Dest Zip Range] = @destZipRange, [Award Type] = @awardTypePS, [Awarded Vol] = @awardedVol, [Awarded Freq] = @awardFreq, " +
                    " Award_Type = @awardType, [Award RPM] = @awardRPM, [Award MIN] = @awardMIN, [Award Flat] = @awardFlat, [Rate Tyle] = @rateTypeFSC, " +
                    " [Effective Date] = @effDate, [Expiration Date] = @expDate, [Rate Number] = @rateNum, [Equipment Type] = @equipType, " +
                    " [Pricing Contact] = @pricingContact, [Pricing Change] = @pricingChange, [Comment] = @comment, [Cust Lane ID] = @custLaneID WHERE [Pricing Rate ID] = @pricingRateId ";


                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@customer", txtCustomer.Text);
                cmd.Parameters.AddWithValue("@parentCustomer", txtParentCustomer.Text);
                cmd.Parameters.AddWithValue("@company", txtCompany.Text);
                cmd.Parameters.AddWithValue("@rateType", txtRateType.Text);
                cmd.Parameters.AddWithValue("@originCity", txtOriginCity.Text);
                cmd.Parameters.AddWithValue("@originState", txtOriginState.Text);
                cmd.Parameters.AddWithValue("@originZip", txtOriginZip.Text);
                cmd.Parameters.AddWithValue("@originZipRange", txtOriginZipRange.Text);
                cmd.Parameters.AddWithValue("@destCity", txtDestCity.Text);
                cmd.Parameters.AddWithValue("@destState", txtDestState.Text);
                cmd.Parameters.AddWithValue("@destZip", txtDestZip.Text);
                cmd.Parameters.AddWithValue("@destZipRange", txtDestZipRange.Text);
                cmd.Parameters.AddWithValue("@awardTypePS", txtAwardTypePS.Text);
                cmd.Parameters.AddWithValue("@awardedVol", txtAwardedVol.Text);
                cmd.Parameters.AddWithValue("@awardFreq", txtAwardFreq.Text);
                cmd.Parameters.AddWithValue("@awardType", txtAwardType.Text);
                cmd.Parameters.AddWithValue("@awardRPM", txtAwardRPM.Text);
                cmd.Parameters.AddWithValue("@awardMIN", txtAwardMIN.Text);
                cmd.Parameters.AddWithValue("@awardFlat", txtAwardFlat.Text);
                cmd.Parameters.AddWithValue("@rateTypeFSC", txtRateTypeFSC.Text);
                cmd.Parameters.AddWithValue("@effDate", txtEffDate.Text);
                cmd.Parameters.AddWithValue("@expDate", txtExpDate.Text);
                cmd.Parameters.AddWithValue("@rateNum", txtRateNumber.Text);
                cmd.Parameters.AddWithValue("@equipType", txtEquipType.Text);
                cmd.Parameters.AddWithValue("@pricingContact", txtPricingContact.Text);
                cmd.Parameters.AddWithValue("@pricingChange", txtPricingChange.Text);
                cmd.Parameters.AddWithValue("@comment", txtComment.Text);
                cmd.Parameters.AddWithValue("@custLaneId", txtCustLaneId.Text);
                cmd.Parameters.AddWithValue("@pricingRateId", txtPricingRateID.Text);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Record updated successfully.");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }

}
