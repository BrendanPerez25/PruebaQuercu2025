﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace PruebaQuercu.Migrations;

public partial class Upgrade_ABP_383 : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<DateTime>(
            name: "ExpireDate",
            table: "AbpUserTokens",
            nullable: true);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "ExpireDate",
            table: "AbpUserTokens");
    }
}
