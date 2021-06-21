using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamworkSystem.DataAccessLayer.Migrations
{
    public partial class UserNameNormalization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "013a2014-4a25-4a3d-9fae-e0f783d42ef9",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b83a8c3-f49c-4e3c-851b-ba1a99e43cd9", "USER4", "AQAAAAEAACcQAAAAEIbGLOfE02rF9yG/irCSfotv/giDxiwiuQQMwiNfq2ZYCZxmWP+qLdSLirXkA5KxTg==", "64ea08f5-1464-4ebd-89de-923e46b42311" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a906f06-fc52-417b-bc81-352df8bbe721",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f48be6d2-f810-45db-a4b4-c7d0a26c2f37", "USER11", "AQAAAAEAACcQAAAAEAuRjnHb7vuYcdVKWRE7kizJn39wFPvfB53wy/RKff0lq3pRYgZ7zVjgaYfKLYgvfg==", "db8a7588-fa46-447c-a601-9ba1489e4269" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b333929-f974-444e-a8d3-68f50a0459c0",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8dc5d30-657f-4794-a78a-8df4f1466441", "USER1", "AQAAAAEAACcQAAAAEP3pt6tiKfs5/h5RRUtSkAKHUVNZza2acg9C3JOKQM7BxBj+eO0bkb2er/NZpR9uvg==", "add55359-e2b0-4b31-a54d-56583a4abbfd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f036c83-88e8-4aeb-ad33-290d60cf6b66",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "701b44cc-0c82-4ee1-93d6-93ba03ff1b1e", "USER9", "AQAAAAEAACcQAAAAEHAg9giGQw3vDZn/NxWLrGpJ2aM9X7FYymdLwSQYFFblKOBl7h/q0tKmRa2jGyWQ/A==", "325f88e7-ecbb-4a79-adb7-848b1db9562e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61dfb9e3-1c27-424a-9963-9586ca110220",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33158a13-5345-4ba1-952f-3740b9cf1693", "USER2", "AQAAAAEAACcQAAAAEK7dQxme3BCH36KAhrtcFW9/SEcmjeHCgwZcFX0SP0nRiYj2fj8/abr6Gk0dYUXoOA==", "1e15fb71-257b-4776-a56a-dbdf644359df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7484e532-dc8e-4005-8b67-15ad8a421a37",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "306cc4c8-ed39-499c-9c08-d12816df91f7", "USER8", "AQAAAAEAACcQAAAAEIr/5TElgZ8R7eQk+nahOHi1sL9TEJDIU31PHbAnW9wwieVT4CpTe0zrvwGBys9d3w==", "02add18e-11dd-4335-a572-bfbb8a9eb327" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ad5c481-f391-45bb-a79c-cfcb1adb448b",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fd016e4-4bd4-43c3-9e62-047e336e145c", "USER10", "AQAAAAEAACcQAAAAEIGyoYSAT/QH2Dof0k0m7rCtWEIgltKs8ju+11y5tfPL1K6/oU8LbB7IVhpMsEUpAQ==", "ac57a6d1-f3b6-41a9-8f2b-025d4a1df3ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a36b02e1-81a9-47f4-89b6-d33c4f40ed5f",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84535de0-ec7a-494e-b1dd-164429e6331c", "USER3", "AQAAAAEAACcQAAAAEE2qBZgiAQBeKikiMC2BfTdovuWPpnma8wl+1SmBiSFHOmJ2zqCeMYrVHzrPz/0Qyw==", "33d7bd21-e9df-47d7-83d8-f4f408a52785" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae557ffc-2906-4913-bd26-40aa98a55570",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29ad475b-7dd5-4d45-b4d0-5eb164796922", "USER5", "AQAAAAEAACcQAAAAEC3oT3FoApS0VuBoIGKKr+MhIGHG5+YLcReWOmZDvgZ5g1/ljkHcwCuwT5tzzYc93g==", "6f0784e3-a998-4b94-87b8-bd86ec47e6ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc0c5522-0a02-4f23-bb6a-319529716a94",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4610cbe4-26e6-4fa5-bc61-70a01139f277", "USER7", "AQAAAAEAACcQAAAAEFgc9FEzNTVVvVjR7Tt40bpB1yvCnMaz6veDiTDPLEUGWr1vadrjvUcf7OBQcSY4qg==", "aa8b5a38-a889-40eb-a4bb-af086abced6b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5ca09a8-d3c6-4114-99a0-6b2f86ff1df2",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "938f0bde-f7b7-4f98-b7bf-e61693fc0d21", "USER6", "AQAAAAEAACcQAAAAEOG/KbJUnt9xgSujJQ+P8d4IalnUIA8ulbwGvqYYUwLM+DcIju8Yj68UjK1ctiXU4A==", "81a33b93-cc9d-4f95-a350-c6a94ac877fe" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2021, 6, 21, 20, 22, 19, 321, DateTimeKind.Local).AddTicks(1306));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "013a2014-4a25-4a3d-9fae-e0f783d42ef9",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbfe6b7a-6d17-4eeb-ab9c-ae8cd6536f14", null, "AQAAAAEAACcQAAAAEHPgR5Hc+ihQA67Efszi9hyIx7t/YrUF8YrpcA9P2bqAAYUr7Cg+/HTbl3xkfWl1ng==", "aecde283-7db1-46e8-9299-41f9c8a45acd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a906f06-fc52-417b-bc81-352df8bbe721",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c59635a-2c32-4245-b37d-9104ebf60455", null, "AQAAAAEAACcQAAAAENku2IV7UEIt6JbIdIX+JzWSXtKFfWsPyVkXqFrrluezGvO1sghvX4O9Z/nyRCYAYQ==", "9634b0f8-1e5e-45b9-8e15-723bd7b32800" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b333929-f974-444e-a8d3-68f50a0459c0",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc7cecac-b3a3-4ab2-8250-f9c13a1a1744", null, "AQAAAAEAACcQAAAAEPLZcHMWVpueMkvsnDtaroPQ/KZF6lVpgAa6sk+qBXlZzdlIjarehgQF3hjOvnxlhw==", "289af02b-0438-4969-863f-8156158ea3f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f036c83-88e8-4aeb-ad33-290d60cf6b66",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9dd32f9-8a9e-440a-a925-25e1d122223c", null, "AQAAAAEAACcQAAAAEONaEM+/CXcsJ4nYHxPEUx76DosoX7WqK2SfnIkwi/oZYCSQmXbZSB8H0YTqXBtQWA==", "f1009259-2396-47b6-a4db-a1f79e5c011f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61dfb9e3-1c27-424a-9963-9586ca110220",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cea8b126-979a-4d7e-a7f1-694234804247", null, "AQAAAAEAACcQAAAAEKCCLLN22UJDj7FzIXEwJAoK4O9PlS2XhndeR1c82rmgT2iAeAmRZ0NcrYvM6RkKqw==", "4eb51f5f-c0d5-4e46-9563-76fc2c2caa8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7484e532-dc8e-4005-8b67-15ad8a421a37",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60d987b4-045f-4213-adba-ed65354cb746", null, "AQAAAAEAACcQAAAAEMiU01V8zfkYMRdbAB1gNuVQxilRhaw6CgrOVI4+V6GyGgzTCL58ceBFeVJAB3RMbQ==", "771a6724-f037-4004-a980-601dfb32e910" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ad5c481-f391-45bb-a79c-cfcb1adb448b",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fca5d29b-46ca-44f1-92ba-33cd849ea575", null, "AQAAAAEAACcQAAAAEBKFHtQPTzymXSRBKwqAq8dXqHRtf+71RCYMufNPhJDcISG/9Md92z02pSVLL+h4/A==", "4008e9f5-73ee-425f-b172-fe5ee1fe3b3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a36b02e1-81a9-47f4-89b6-d33c4f40ed5f",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84f65ecf-ca5f-487f-9dc1-fa7bcfd2befb", null, "AQAAAAEAACcQAAAAEB+5u1bKlNGCHc/iMXqQ83WxLA+NGgIlBgJoSGSe7QXfforsJnUnK3izvf1bARy7BA==", "5746a5ee-2945-4bf3-903e-afac790b581d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae557ffc-2906-4913-bd26-40aa98a55570",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b94672f3-c461-43f6-a62d-62a151f30a9e", null, "AQAAAAEAACcQAAAAEMQA31d5n9ZJp4gPknAMhTwGjsr1ThMPWlgOxe+Srt1u8sV9b53EMTWaXG1cRFrGtQ==", "00e7872a-d04e-411c-abba-9771d813ab9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc0c5522-0a02-4f23-bb6a-319529716a94",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "819e89e9-e98f-499b-85b4-15bda3e1df3c", null, "AQAAAAEAACcQAAAAEKrKz0HVqwZH+dd6x8GtpW5yiq6h7vPT3xDfRviaciyB9qI697Ga7l4wN+LAZ6ZRWg==", "ffe78ca5-bcd1-4650-9096-c484eb39cdaa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5ca09a8-d3c6-4114-99a0-6b2f86ff1df2",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca3d4ec2-65f9-4f18-bf52-d8ec1c52c5c2", null, "AQAAAAEAACcQAAAAEPLyObs8N0P0gP6mo+mERHtDRfpdfd+u+9YeWoIfa2HFub4XiE341B5GrHcR+ToDmA==", "127677c8-1b0d-4858-8e33-ac6c129debc8" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2021, 5, 25, 13, 27, 52, 436, DateTimeKind.Local).AddTicks(7346));
        }
    }
}
