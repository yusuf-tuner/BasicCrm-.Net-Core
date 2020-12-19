using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class spcustomerDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
	        var sp = @" create procedure customerDetails
						as
						select * from Customers ";
	        migrationBuilder.Sql(sp);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
