using PPCOM.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPCOM.Data
{
    public class QuotationRepository
    {
        string connStr = @"Server=(localdb)\MSSQLLocalDB;Database=PPCOM;Integrated Security=True;";
        public int AddQuotation(Quotation quo)
        {
            int quotationId;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_create_quotation", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@customer_id", 1); // temp
                cmd.Parameters.AddWithValue("@quotation_date", quo.quotationDate);

                cmd.Parameters.AddWithValue("@customer_name", quo.customerName);
                cmd.Parameters.AddWithValue("@addresses", quo.addresses);
                cmd.Parameters.AddWithValue("@product_name", quo.productName);
                cmd.Parameters.AddWithValue("@expiry", quo.expiry);
                cmd.Parameters.AddWithValue("@delivery_time", quo.deliveryTime);
                cmd.Parameters.AddWithValue("@profit", quo.profit);

                quotationId = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return quotationId;
        }

        public void AddQuotationDetail(QuotationDetail detail)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_add_quotation_detail", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@quotation_id", detail.quotationId);

                cmd.Parameters.AddWithValue("@prodX", detail.prodX);
                cmd.Parameters.AddWithValue("@prodY", detail.prodY);
                cmd.Parameters.AddWithValue("@prodZ", detail.prodZ);

                cmd.Parameters.AddWithValue("@product_amount", detail.productAmount);
                cmd.Parameters.AddWithValue("@color_amount", detail.colorAmount);
                cmd.Parameters.AddWithValue("@units_per_sheet", detail.unitsPerSheet);

                cmd.Parameters.AddWithValue("@print_length", detail.printLength);
                cmd.Parameters.AddWithValue("@print_width", detail.printWidth);
                cmd.Parameters.AddWithValue("@waste_sheet", detail.wasteSheet);

                cmd.Parameters.AddWithValue("@big_printer", detail.bigPrinter);

                cmd.Parameters.AddWithValue("@paper_type_id", detail.paperTypeId);

                cmd.Parameters.AddWithValue("@uv_frame_cost", detail.uvFrameCost);
                cmd.Parameters.AddWithValue("@diecut_frame_cost", detail.dieCutFrameCost);
                cmd.Parameters.AddWithValue("@delivery_and_proof", detail.deliveryAndProof);

                cmd.ExecuteNonQuery();
            }
        }

        public List<paperType> GetPaperTypes()
        {
            List<paperType> list = new List<paperType>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_get_paper_types", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new paperType
                    {
                        paperTypeId = (int)reader["paper_type_id"],
                        paperName = reader["paper_name"].ToString(),
                        gsm = (int)reader["gsm"],
                        pricePerTon = (int)reader["price_per_ton"]
                    });
                }
            }

            return list;
        }
    }
}
