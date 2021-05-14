using LS_Action.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LS_Action.MockData
{
    public class MockUserData
    {
        public MockUserData()
        {
            this.Supporters = new List<Users>();

            this.Supporters.Add(new Users
            {
                username = "admin",
                password = "Admin@123",
                email = "tanhoatm@gmail.com",
                fullname = "Nguyễn Trí Hậu",
                phone = "0359759402",
                avatar = "https://st.quantrimang.com/photos/image/2017/04/08/anh-dai-dien-FB-200.jpg"
            });

            this.Supporters.Add(new Users
            {
                username = "user0001",
                password = "User@123",
                email = "tanhoatm@gmail.com",
                phone = "0359759402",
                fullname = "Administrator",
                avatar = "https://st.quantrimang.com/photos/image/2017/04/08/anh-dai-dien-FB-200.jpg"
            });

            this.Supporters.Add(new Users
            {
                username = "employee",
                password = "Employee@123",
                email = "tanhoatm@gmail.com",
                phone = "023213231231",
                fullname = "User000002",
                avatar = "https://st.quantrimang.com/photos/image/2017/04/08/anh-dai-dien-FB-200.jpg"
            });

            this.Supporters.Add(new Users
            {
                username = "user00002",
                password = "Admin@123",
                email = "user@gmail.com",
                phone = "0359759402",
                fullname = "User0000024",
                avatar = "https://st.quantrimang.com/photos/image/2017/04/08/anh-dai-dien-FB-200.jpg"
            });

            this.Supporters.Add(new Users
            {
                username = "user00005",
                password = "Admin@123",
                email = "user0001@gmail.com",
                phone = "0359759402",
                fullname = "User0000065",
                avatar = "https://st.quantrimang.com/photos/image/2017/04/08/anh-dai-dien-FB-200.jpg"
            });
        }

        public List<Users> Supporters { get; set; }
    }
}
