using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Db_customer
{
    #region Customer
    public class Customer
    {
        #region Member Variables
        protected int _ID;
        protected string _Nama;
        protected string _Email;
        protected string _NoTelp;
        protected string _Instagram;
        protected unknown _TanggalLahir;
        protected string _Pekerjaan;
        protected string _InstansiUniversitas;
        #endregion
        #region Constructors
        public Customer() { }
        public Customer(string Nama, string Email, string NoTelp, string Instagram, unknown TanggalLahir, string Pekerjaan, string InstansiUniversitas)
        {
            this._Nama=Nama;
            this._Email=Email;
            this._NoTelp=NoTelp;
            this._Instagram=Instagram;
            this._TanggalLahir=TanggalLahir;
            this._Pekerjaan=Pekerjaan;
            this._InstansiUniversitas=InstansiUniversitas;
        }
        #endregion
        #region Public Properties
        public virtual int ID
        {
            get {return _ID;}
            set {_ID=value;}
        }
        public virtual string Nama
        {
            get {return _Nama;}
            set {_Nama=value;}
        }
        public virtual string Email
        {
            get {return _Email;}
            set {_Email=value;}
        }
        public virtual string NoTelp
        {
            get {return _NoTelp;}
            set {_NoTelp=value;}
        }
        public virtual string Instagram
        {
            get {return _Instagram;}
            set {_Instagram=value;}
        }
        public virtual unknown TanggalLahir
        {
            get {return _TanggalLahir;}
            set {_TanggalLahir=value;}
        }
        public virtual string Pekerjaan
        {
            get {return _Pekerjaan;}
            set {_Pekerjaan=value;}
        }
        public virtual string InstansiUniversitas
        {
            get {return _InstansiUniversitas;}
            set {_InstansiUniversitas=value;}
        }
        #endregion
    }
    #endregion
}