﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ViolinSuzukiLeila
{
    class Helper
    {
        SqlConnection cnn;
        SqlCommand cmd;
        string cnnString;

        public Helper()
        {
            cnnString = @"Data Source=NTB62275\SQLEXPRESS;Initial Catalog=VIOLIN_SUZUKI_LEILA;Integrated Security=True";
            cnn = new SqlConnection(cnnString);
            cmd = new SqlCommand();
        }

        public DataTable Consultar(string nombreSP, List<Parametro> lstParametros)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            cmd.Parameters.Clear();

            foreach (Parametro p in lstParametros)
            {
                cmd.Parameters.AddWithValue(p.pNombre, p.pValor);
            }

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            return dt;
        }

        public DataTable Consultar(string nombreSP)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            cmd.Parameters.Clear();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            return dt;
        }

        public int? ConsultarID(string nombreSP)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            cmd.Parameters.Clear();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            int? result = Convert.ToInt32(dt.Rows[0][0]);
            cnn.Close();
            return result;
        }

        public DataTable Consultar(string nombreSP, Parametro param)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue(param.pNombre, param.pValor);
            

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            return dt;
        }
        public bool Insertar(string nombreSP, List<Parametro> lstParametros)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            cmd.Parameters.Clear();

            foreach (Parametro p in lstParametros)
            {
                cmd.Parameters.AddWithValue(p.pNombre, p.pValor);
            }

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            cnn.Close();
            return false;
        }
    }
}
