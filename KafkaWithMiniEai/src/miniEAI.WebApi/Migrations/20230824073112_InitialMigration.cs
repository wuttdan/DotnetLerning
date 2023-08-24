using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace miniEAI.WebApi.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "HEADERID_SEQ",
                minValue: 1L);

            migrationBuilder.CreateSequence(
                name: "REFID_SEQ",
                minValue: 1L);

            migrationBuilder.CreateTable(
                name: "FBB_TBL_EVAUTHORIZATION_HEADER",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TRANSACTION_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ACIM_VERSION = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ACIM_APPNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ACIM_CLIENT_ID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ACTION = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STATUS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    SERVER_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_EVAUTHORIZATION_HEADER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_EVAUTOAPPROVE_HEADER",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TRANSACTION_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TIMESTAMP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STATUS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    SERVER_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_EVAUTOAPPROVE_HEADER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_EVCUSTOMERINFO_HEADER",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TRANSACTION_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    INTERNET_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ORDER_NO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STATUS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    SERVER_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_EVCUSTOMERINFO_HEADER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_EVJOBAPPROVE_HEADER",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TRANSACTION_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    INTERNET_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ORDER_NO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STATUS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    SERVER_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_EVJOBAPPROVE_HEADER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_EVJOBINCOMPLETE_HEADER",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TRANSACTION_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    INTERNET_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ORDER_NO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STATUS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    SERVER_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_EVJOBINCOMPLETE_HEADER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_EVMICROSITE_HEADER",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TRANSACTION_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ORDER_NO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STATUS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    SERVER_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_EVMICROSITE_HEADER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_EVMICROSITEUPD_HEADER",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TRANSACTION_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ORDER_NO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STATUS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    SERVER_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_EVMICROSITEUPD_HEADER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_EVNOTIFYAPPOINTMENT_HEADER",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TRANSACTION_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FIBRENET_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TYPE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ORDER_TYPE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TYPE_OPER_DATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MSG_SEQ_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STATUS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    SERVER_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_EVNOTIFYAPPOINTMENT_HEADER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_EVSENDCHECKLATE_HEADER",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TRANSACTION_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    INTERNET_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ORDER_NO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ORDER_TYPE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    STATUS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    SERVER_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_EVSENDCHECKLATE_HEADER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_EXCEPTION_ERROR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TRANSACTION_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SERVICE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FUCNTION = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ERROR_MESSAGE = table.Column<string>(type: "text", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_EXCEPTION_ERROR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_LIST_OF_VALUE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LOV_NAME = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    LOV_VALUE1 = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    LOV_VALUE2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LOV_VALUE3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ACTIVE_FLAG = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    EXTERNAL_ID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    CREATED = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_LOGGING",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TRANSACTION_ID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    REQUEST_MESSAGE = table.Column<string>(type: "text", nullable: true),
                    REQUEST_EVENT = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    REQUEST_METHOD = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    REQUEST_PATH = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REQUEST_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_LOGGING", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_MAPPING_ID",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TYPE_EVENT = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    APP_SOURCE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    RESPONSE_TIME = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_MAPPING_ID", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_MAPPING_WO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MAPPING_ID = table.Column<int>(type: "int", nullable: false),
                    DESTINATION = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EXTERNAL_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TYPE_EXTERNAL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SEQ_NUM = table.Column<int>(type: "int", nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_MAPPING_WO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_WO",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ORDER_NO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TRANSACTION_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DESTINATION = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EXTERNAL_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STATUS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    REQUEST_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    RESPONSE_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    RETRY_NO = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((-1))"),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_WO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_EVAUTHORIZATION_DETAIL",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HEADER_ID = table.Column<long>(type: "bigint", nullable: false),
                    USERNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FIRST_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LAST_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ROLE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ROLE_PAST = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PERIOD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    START_DATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    END_DATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LOCATION_CODE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LOCATION_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_EVAUTHORIZATION_DETAIL", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_EVAUTHORIZATION_DETAIL_FBB_TBL_EVAUTHORIZATION_HEADER",
                        column: x => x.HEADER_ID,
                        principalTable: "FBB_TBL_EVAUTHORIZATION_HEADER",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_EVCUSTOMERINFO_DETAIL",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HEADER_ID = table.Column<long>(type: "bigint", nullable: false),
                    FIELD_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TYPE_GROUP = table.Column<int>(type: "int", nullable: true),
                    FIELD_VALUE = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_EVCUSTOMERINFO_DETAIL", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_EVCUSTOMERINFO_DETAIL_FBB_TBL_EVCUSTOMERINFO_HEADER",
                        column: x => x.HEADER_ID,
                        principalTable: "FBB_TBL_EVCUSTOMERINFO_HEADER",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_EVJOBAPPROVE_DETAIL",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HEADER_ID = table.Column<long>(type: "bigint", nullable: false),
                    APPROVE_TIME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_EVJOBAPPROVE_DETAIL", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_EVJOBAPPROVE_DETAIL_FBB_TBL_EVJOBAPPROVE_HEADER",
                        column: x => x.HEADER_ID,
                        principalTable: "FBB_TBL_EVJOBAPPROVE_HEADER",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_EVJOBINCOMPLETE_DETAIL",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HEADER_ID = table.Column<long>(type: "bigint", nullable: false),
                    REASON = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    SUB_REASON = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    REMARK = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    ATTRIBUTE_VALUE = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ATTRIBUTE_DESC = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    INCOMPLETE_TIME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_EVJOBINCOMPLETE_DETAIL", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_EVJOBINCOMPLETE_DETAIL_FBB_TBL_EVJOBINCOMPLETE_HEADER",
                        column: x => x.HEADER_ID,
                        principalTable: "FBB_TBL_EVJOBINCOMPLETE_HEADER",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_EVMICROSITE_DETAIL",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HEADER_ID = table.Column<long>(type: "bigint", nullable: false),
                    USER = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    SEGMENT = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NUMBER_OF_USER = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RESIDENTIAL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TYPE_OF_USER = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PACKAGE = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PACKAGE_CODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SPEED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PLAYBOX_BUNDLE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PLAYBOX_ADDON = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ROUTER_BUNDLE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ROUTER_ADDON = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PRICE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    FIRSTNAME = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    LASTNAME = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    TELEPHONE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ADDRESS = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    SUBDISTRICT = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    DISTRICT = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    PROVINCE = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ZIPCODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MEDIA_STREAMING = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    USER_JOURNEY = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CID = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    COMPLETE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_EVMICROSITE_DETAIL", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_EVMICROSITE_DETAIL_FBB_TBL_EVMICROSITE_HEADER",
                        column: x => x.HEADER_ID,
                        principalTable: "FBB_TBL_EVMICROSITE_HEADER",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_EVMICROSITEUPD_DETAIL",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HEADER_ID = table.Column<long>(type: "bigint", nullable: false),
                    ORDER_CHANNEL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IS_CONTACT_CUSTOMER = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IS_IN_COVERAGE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    USER_ACTION = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DATE_ACTION = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ORDER_PRE_REGISTER = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    STATUS_ORDER = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    REMARK_NOTE = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_EVMICROSITEUPD_DETAIL", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_EVMICROSITEUPD_DETAIL_FBB_TBL_EVMICROSITEUPD_HEADER",
                        column: x => x.HEADER_ID,
                        principalTable: "FBB_TBL_EVMICROSITEUPD_HEADER",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_EVNOTIFYAPPOINTMENT_ORDER",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HEADER_ID = table.Column<long>(type: "bigint", nullable: false),
                    CUSTOMER_ORDER_NO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FBSS_ORDER_NO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TASK_ORDER_NO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TROUBLE_TICKET_NO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SIEBEL_REQUEST_NO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FIBRENET_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    JOB_STATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    JOB_PRIORITY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PRODUCT_NAME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ACCESS_MODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SERVICE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DOWNLINK_RATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UPLINK_RATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    COMMIT_DATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ACCEPT_DATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TROUBLE_SYMPTOM = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    COMPLAINT_TITLE = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CUSTOMER_COMPLAINT_NAME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CUSTOMER_COMPLAINT_MOBILE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NOC_REMARK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOC_NUMBER = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DETAILS_FOR_RESOLVED = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COMPLAINT_DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ORDER_TYPE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REPLACE_ONT_FLAG = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REPLACE_ROUTER_FLAG = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ROUTER_NUM = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CUSTOMER_NAME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CONTACT_PERSON_NAME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CONTACT_MOBILE_PHONE1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CONTACT_MOBILE_PHONE2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CONTACT_MOBILE_PHONE3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    INSTALLATION_ADDRESS = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    INSTALLATION_LATITUDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    INSTALLATION_LONGITUDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BRAND = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EVENTFLOW_FLAG = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SERVICE_LEVEL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ONTOP_PACK = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SERVICE_PACK = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    VOIP_NUMBER1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VOIP_PASSWORD1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VOIP_NUMBER2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VOIP_PASSWORD2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PLAYBOX_CONTENT = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    TOTAL_FEE = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    APPOINTMENT_DATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    APPOINTMENT_TIMESLOT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_EVNOTIFYAPPOINTMENT_ORDER", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_EVNOTIFYAPPOINTMENT_ORDER_FBB_TBL_EVNOTIFYAPPOINTMENT_HEADER",
                        column: x => x.HEADER_ID,
                        principalTable: "FBB_TBL_EVNOTIFYAPPOINTMENT_HEADER",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_EVSENDCHECKLATE_DETAIL",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HEADER_ID = table.Column<long>(type: "bigint", nullable: false),
                    MN_APPOINTMENT_DATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MN_SLOT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MN_PACKAGE = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    MN_PRODUCT_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MN_CUSTOMER_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MN_CUSTOMER_ADDRESS = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    MN_CUSTOMER_LATITUDE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MN_CUSTOMER_LONGITUDE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MN_REGION = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MN_STAFF_CODE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MN_STAFF_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MN_STAFF_PHONE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MN_SUBCONTRACT_TEAM = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MN_CHECKIN_LATE_TIME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MN_CHECKIN_LATE_REASON = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    MN_CURRENT_LATITUDE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MN_CURRENT_LONGITUDE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MN_CREATE_DATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MN_CREATED_BY = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MN_CUSTOMER_CONTACT_1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MN_CUSTOMER_CONTACT_2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MN_CUSTOMER_CONTACT_3 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MN_REMARKS = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    REFID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LATE_DURATION = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_EVSENDCHECKLATE_DETAIL", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_EVSENDCHECKLATE_DETAIL_FBB_TBL_EVSENDCHECKLATE_HEADER",
                        column: x => x.HEADER_ID,
                        principalTable: "FBB_TBL_EVSENDCHECKLATE_HEADER",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_MAPPING_VALIDATE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MAPPING_ID = table.Column<int>(type: "int", nullable: true),
                    TYPE_EVENT = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    APP_SOURCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PARAMETER_XML = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CONSTRAINT_VALIDATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ACTIVE_FLAG = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_MAPPING_VALIDATE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_MAPPING_VALIDATE_FBB_TBL_MAPPING_ID",
                        column: x => x.MAPPING_ID,
                        principalTable: "FBB_TBL_MAPPING_ID",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_MAPPING_EXTERNAL",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MAPPING_WO = table.Column<int>(type: "int", nullable: false),
                    EXTERNAL_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TYPEWS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ENDPOINT_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    URL_ENDPOINT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IS_ONLINE = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    RETRY_COUNT = table.Column<int>(type: "int", nullable: true),
                    SLEEP_TIMES = table.Column<int>(type: "int", nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    REQUEST_TIMEOUT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_MAPPING_EXTERNAL", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_MAPPING_EXTERNAL_FBB_TBL_MAPPING_WO",
                        column: x => x.MAPPING_WO,
                        principalTable: "FBB_TBL_MAPPING_WO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_MAPPING_PARAMETER",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MAPPING_WO = table.Column<int>(type: "int", nullable: false),
                    EXTERNAL_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PARAM_XML_NAME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SOURCE_TABLE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DEFAULT_VALUE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    COLUMN_NAME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FIELD_NAME_VALUE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FORMAT_VALUE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SEQ_NUM = table.Column<int>(type: "int", nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_MAPPING_PARAMETER", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_MAPPING_PARAMETER_FBB_TBL_MAPPING_WO",
                        column: x => x.MAPPING_WO,
                        principalTable: "FBB_TBL_MAPPING_WO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_WO_ATTRIBUTE",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WO_ID = table.Column<long>(type: "bigint", nullable: true),
                    NAME = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    VALUE = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    TYPE_GROUP = table.Column<int>(type: "int", nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_WO_ATTRIBUTE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_WO_ATTRIBUTE_FBB_TBL_WO",
                        column: x => x.WO_ID,
                        principalTable: "FBB_TBL_WO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_WO_BLAME",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WO_ID = table.Column<long>(type: "bigint", nullable: true),
                    FIELD_PATH = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VALUE_BEFORE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VALUE_AFTER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_WO_BLAME", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_WO_BLAME_FBB_TBL_WO",
                        column: x => x.WO_ID,
                        principalTable: "FBB_TBL_WO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_WO_ERROR_MESSAGE",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WO_ID = table.Column<long>(type: "bigint", nullable: true),
                    ERROR_CODE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ERROR_DESC = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    REMARK = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_WO_ERROR_MESSAGE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_WO_ERROR_MESSAGE_FBB_TBL_WO",
                        column: x => x.WO_ID,
                        principalTable: "FBB_TBL_WO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_WO_SOA_COMPANIES",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WO_ID = table.Column<long>(type: "bigint", nullable: true),
                    STAFF_ID = table.Column<long>(type: "bigint", nullable: true),
                    GROUP = table.Column<int>(type: "int", nullable: true),
                    COMPANY_NAME = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    COMPANY_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VENDOR_CODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LOCATION_CODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STORAGE_LOCATION = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_WO_SOA_COMPANIES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_WO_SOA_COMPANIES_FBB_TBL_WO",
                        column: x => x.WO_ID,
                        principalTable: "FBB_TBL_WO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_WO_SOA_CRMS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WO_ID = table.Column<long>(type: "bigint", nullable: true),
                    GROUP = table.Column<int>(type: "int", nullable: true),
                    AUTHOR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SUBCONTRACT_REMARKS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REMARK_DATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_WO_SOA_CRMS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_WO_SOA_CRMS_FBB_TBL_WO",
                        column: x => x.WO_ID,
                        principalTable: "FBB_TBL_WO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_WO_SOA_FEES",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WO_ID = table.Column<long>(type: "bigint", nullable: true),
                    GROUP = table.Column<int>(type: "int", nullable: true),
                    DATA = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_WO_SOA_FEES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_WO_SOA_FEES_FBB_TBL_WO",
                        column: x => x.WO_ID,
                        principalTable: "FBB_TBL_WO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_WO_SOA_HEADER",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WO_ID = table.Column<long>(type: "bigint", nullable: true),
                    FIBRENET_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TYPE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ORDER_TYPE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TYPE_OPER_DATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MSG_SEQ_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_WO_SOA_HEADER", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_WO_SOA_HEADER_FBB_TBL_WO",
                        column: x => x.WO_ID,
                        principalTable: "FBB_TBL_WO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_WO_SOA_INSTALL_ORDER",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WO_ID = table.Column<long>(type: "bigint", nullable: true),
                    CUSTOMER_ORDER_NO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FBSS_ORDER_NO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TASK_ORDER_NO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FIBRENET_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    JOB_STATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    JOB_PRIORITY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PRODUCT_NAME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ACCESS_MODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ORDER_TYPE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REPLACE_ONT_FLAG = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    REPLACE_ROUTER_FLAG = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ROUTER_NUM = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CUSTOMER_NAME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CONTACT_PERSON_NAME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CONTACT_MOBILE_PHONE1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CONTACT_MOBILE_PHONE2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CONTACT_MOBILE_PHONE3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    INSTALLATION_ADDRESS = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    INSTALLATION_LATITUDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    INSTALLATION_LONGITUDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BRAND = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EVENTFLOW_FLAG = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SERVICE_LEVEL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ONTOP_PACK = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SERVICE_PACK = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    VOIP_NUMBER1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VOIP_PASSWORD1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VOIP_NUMBER2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VOIP_PASSWORD2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PLAYBOX_CONTENT = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    TOTAL_FEE = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    APPOINTMENT_DATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    APPOINTMENT_TIMESLOT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    BUILDING_NAME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AREA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    REGION = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CS_NOTE = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_WO_SOA_INSTALL_ORDER", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_WO_SOA_INSTALL_ORDER_FBB_TBL_WO",
                        column: x => x.WO_ID,
                        principalTable: "FBB_TBL_WO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_WO_SOA_MA_ORDER",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WO_ID = table.Column<long>(type: "bigint", nullable: false),
                    TROUBLE_TICKET_NO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SIEBEL_REQUEST_NO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TASK_ORDER_NO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FIBRENET_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    JOB_STATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    JOB_PRIORITY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PRODUCT_NAME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SERVICE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ACCESS_MODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DOWNLINK_RATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UPLINK_RATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    COMMIT_DATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ACCEPT_DATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TROUBLE_SYMPTOM = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    COMPLAINT_TITLE = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CUSTOMER_COMPLAINT_NAME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CUSTOMER_COMPLAINT_MOBILE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NOC_REMARK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOC_NUMBER = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DETAILS_FOR_RESOLVED = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COMPLAINT_DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CUSTOMER_NAME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CONTACT_PERSON_NAME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CONTACT_MOBILE_PHONE1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CONTACT_MOBILE_PHONE2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CONTACT_MOBILE_PHONE3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    APPOINTMENT_DATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    APPOINTMENT_TIMESLOT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    INSTALLATION_LATITUDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    INSTALLATION_LONGITUDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SERVICE_LEVEL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BUILDING_NAME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AREA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    REGION = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ADDRESS = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CS_NOTE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ONTOP_PACK = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SERVICE_PACK = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PLAYBOX_CONTENT = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_WO_SOA_MA_ORDER", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_WO_SOA_MA_ORDER_FBB_TBL_WO",
                        column: x => x.WO_ID,
                        principalTable: "FBB_TBL_WO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_WO_SOA_ONTOPS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WO_ID = table.Column<long>(type: "bigint", nullable: true),
                    GROUP = table.Column<int>(type: "int", nullable: true),
                    DATA = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_WO_SOA_ONTOPS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_WO_SOA_ONTOPS_FBB_TBL_WO",
                        column: x => x.WO_ID,
                        principalTable: "FBB_TBL_WO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_WO_SOA_RESOURCE",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WO_ID = table.Column<long>(type: "bigint", nullable: true),
                    SERVICE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DOWNLINK_RATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UPLINK_RATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PASSWORD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CPE_MODEL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SPLITTER_PORT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SPLITTER_NAME_PRIMARY = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OLT_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ACTIVATION_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CPE_SN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CVLAN = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DEVICE_MODEL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DSLAM_MANUFACTURER = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DSLAM_PORT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MDF_OUT_PORT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ODF_FIBER_CORE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SP1_FIBER_CORE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GEMPORT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    STANDARD_ADDRESS_NAME = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IP_ADDRESS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SP1_LATITUDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SP1_LONGITUDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SP2_LATITUDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SP2_LONGITUDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ODF_IN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ODF_OUT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OLT_MANUFACTURER = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OLT_PON_PORT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ONU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ONU_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ONU_MODEL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ONU_UPLINK_PORT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SP1_RUNNING_STATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SP2_RUNNING_STATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SPLITTER_DISTANCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SP1_IN_PORT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SP2_IN_PORT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SP1_OUT_PORT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SP2_OUT_PORT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SVLAN = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TCONT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SP2_DISTANCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DROP_WIRE_DISTANCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EXISTING_DROP_WIRE_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    END_POINT_LATITUDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    END_POINT_LONGITUDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NEW_DROP_WIRE_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    REUSE_FLAG = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CPE_INSTALLATION = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_WO_SOA_RESOURCE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_WO_SOA_RESOURCE_FBB_TBL_WO",
                        column: x => x.WO_ID,
                        principalTable: "FBB_TBL_WO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_WO_SOA_STAFFS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WO_ID = table.Column<long>(type: "bigint", nullable: false),
                    GROUP = table.Column<int>(type: "int", nullable: true),
                    STAFF_CODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STAFF_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    STAFF_PHONE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    STAFF_EMAIL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    STAFF_LATITUDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STAFF_LONGITUDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STAFF_FIRST_DAY_WORKING = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STAFF_END_DAY_WORKING = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STAFF_ROLE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    STAFF_PROFILE_PICTURE_FILENAME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_WO_SOA_STAFFS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_WO_SOA_STAFFS_FBB_TBL_WO",
                        column: x => x.WO_ID,
                        principalTable: "FBB_TBL_WO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_WO_SOA_TEAMS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WO_ID = table.Column<long>(type: "bigint", nullable: false),
                    COMPANY_ID = table.Column<long>(type: "bigint", nullable: true),
                    GROUP = table.Column<int>(type: "int", nullable: true),
                    TEAM_NAME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TEAM_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TEAM_SERVICE = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    VENDOR_CODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LOCATION_CODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STORAGE_LOCATION = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SHIP_TO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_WO_SOA_TEAMS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_WO_SOA_TEAMS_FBB_TBL_WO",
                        column: x => x.WO_ID,
                        principalTable: "FBB_TBL_WO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_WO_SOA_WFMS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WO_ID = table.Column<long>(type: "bigint", nullable: true),
                    GROUP = table.Column<int>(type: "int", nullable: true),
                    AUTHOR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SUBCONTRACT_REMARKS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REMARK_DATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_WO_SOA_WFMS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_WO_SOA_WFMS_FBB_TBL_WO",
                        column: x => x.WO_ID,
                        principalTable: "FBB_TBL_WO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_EVNOTIFYAPPOINTMENT_COMPANIES",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ORDER_ID = table.Column<long>(type: "bigint", nullable: false),
                    STAFF_ID = table.Column<long>(type: "bigint", nullable: true),
                    GROUP = table.Column<int>(type: "int", nullable: true),
                    COMPANY_NAME = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    COMPANY_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VENDOR_CODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LOCATION_CODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STORAGE_LOCATION = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_EVNOTIFYAPPOINTMENT_COMPANIES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_EVNOTIFYAPPOINTMENT_COMPANIES_FBB_TBL_EVNOTIFYAPPOINTMENT_ORDER",
                        column: x => x.ORDER_ID,
                        principalTable: "FBB_TBL_EVNOTIFYAPPOINTMENT_ORDER",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_EVNOTIFYAPPOINTMENT_CRMS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ORDER_ID = table.Column<long>(type: "bigint", nullable: false),
                    GROUP = table.Column<int>(type: "int", nullable: true),
                    AUTHOR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SUBCONTRACT_REMARKS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REMARK_DATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_EVNOTIFYAPPOINTMENT_CRMS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_EVNOTIFYAPPOINTMENT_CRMS_FBB_TBL_EVNOTIFYAPPOINTMENT_ORDER",
                        column: x => x.ORDER_ID,
                        principalTable: "FBB_TBL_EVNOTIFYAPPOINTMENT_ORDER",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_EVNOTIFYAPPOINTMENT_FEES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ORDER_ID = table.Column<long>(type: "bigint", nullable: false),
                    GROUP = table.Column<int>(type: "int", nullable: true),
                    DATA = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_EVNOTIFYAPPOINTMENT_FEES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_EVNOTIFYAPPOINTMENT_FEES_FBB_TBL_EVNOTIFYAPPOINTMENT_ORDER",
                        column: x => x.ORDER_ID,
                        principalTable: "FBB_TBL_EVNOTIFYAPPOINTMENT_ORDER",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_EVNOTIFYAPPOINTMENT_ONTOPS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ORDER_ID = table.Column<long>(type: "bigint", nullable: false),
                    GROUP = table.Column<int>(type: "int", nullable: true),
                    DATA = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_EVNOTIFYAPPOINTMENT_ONTOPS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_EVNOTIFYAPPOINTMENT_ONTOPS_FBB_TBL_EVNOTIFYAPPOINTMENT_ORDER",
                        column: x => x.ORDER_ID,
                        principalTable: "FBB_TBL_EVNOTIFYAPPOINTMENT_ORDER",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_EVNOTIFYAPPOINTMENT_RESOURCE",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ORDER_ID = table.Column<long>(type: "bigint", nullable: false),
                    SERVICE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DOWNLINK_RATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UPLINK_RATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PASSWORD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CPE_MODEL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SPLITTER_PORT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SPLITTER_NAME_PRIMARY = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OLT_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ACTIVATION_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CPE_SN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CVLAN = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DEVICE_MODEL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DSLAM_MANUFACTURER = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DSLAM_PORT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MDF_OUT_PORT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ODF_FIBER_CORE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SP1_FIBER_CORE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GEMPORT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    STANDARD_ADDRESS_NAME = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IP_ADDRESS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SP1_LATITUDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SP1_LONGITUDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SP2_LATITUDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SP2_LONGITUDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ODF_IN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ODF_OUT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OLT_MANUFACTURER = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OLT_PON_PORT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ONU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ONU_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ONU_MODEL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ONU_UPLINK_PORT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SP1_RUNNING_STATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SP2_RUNNING_STATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SPLITTER_DISTANCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SP1_IN_PORT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SP2_IN_PORT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SP1_OUT_PORT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SP2_OUT_PORT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SVLAN = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TCONT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SP2_DISTANCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DROP_WIRE_DISTANCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EXISTING_DROP_WIRE_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    END_POINT_LATITUDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    END_POINT_LONGITUDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NEW_DROP_WIRE_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    REUSE_FLAG = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CPE_INSTALLATION = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_EVNOTIFYAPPOINTMENT_RESOURCE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_EVNOTIFYAPPOINTMENT_RESOURCE_FBB_TBL_EVNOTIFYAPPOINTMENT_ORDER",
                        column: x => x.ORDER_ID,
                        principalTable: "FBB_TBL_EVNOTIFYAPPOINTMENT_ORDER",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_EVNOTIFYAPPOINTMENT_STAFFS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ORDER_ID = table.Column<long>(type: "bigint", nullable: false),
                    GROUP = table.Column<int>(type: "int", nullable: true),
                    STAFF_CODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STAFF_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    STAFF_PHONE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    STAFF_EMAIL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    STAFF_LATITUDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STAFF_LONGITUDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STAFF_FIRST_DAY_WORKING = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STAFF_END_DAY_WORKING = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STAFF_ROLE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    STAFF_PROFILE_PICTURE_FILENAME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_EVNOTIFYAPPOINTMENT_STAFFS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_EVNOTIFYAPPOINTMENT_STAFFS_FBB_TBL_EVNOTIFYAPPOINTMENT_ORDER",
                        column: x => x.ORDER_ID,
                        principalTable: "FBB_TBL_EVNOTIFYAPPOINTMENT_ORDER",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_EVNOTIFYAPPOINTMENT_TEAMS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ORDER_ID = table.Column<long>(type: "bigint", nullable: false),
                    COMPANY_ID = table.Column<long>(type: "bigint", nullable: true),
                    GROUP = table.Column<int>(type: "int", nullable: true),
                    TEAM_NAME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TEAM_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TEAM_SERVICE = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    VENDOR_CODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LOCATION_CODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STORAGE_LOCATION = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SHIP_TO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_EVNOTIFYAPPOINTMENT_TEAMS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_EVNOTIFYAPPOINTMENT_TEAMS_FBB_TBL_EVNOTIFYAPPOINTMENT_ORDER",
                        column: x => x.ORDER_ID,
                        principalTable: "FBB_TBL_EVNOTIFYAPPOINTMENT_ORDER",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FBB_TBL_EVNOTIFYAPPOINTMENT_WFMS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ORDER_ID = table.Column<long>(type: "bigint", nullable: false),
                    GROUP = table.Column<int>(type: "int", nullable: true),
                    AUTHOR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SUBCONTRACT_REMARKS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REMARK_DATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LAST_UPD_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBB_TBL_EVNOTIFYAPPOINTMENT_WFMS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FBB_TBL_EVNOTIFYAPPOINTMENT_WFMS_FBB_TBL_EVNOTIFYAPPOINTMENT_ORDER",
                        column: x => x.ORDER_ID,
                        principalTable: "FBB_TBL_EVNOTIFYAPPOINTMENT_ORDER",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_EVAUTHORIZATION_DETAIL_HEADER_ID",
                table: "FBB_TBL_EVAUTHORIZATION_DETAIL",
                column: "HEADER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_EVCUSTOMERINFO_DETAIL_HEADER_ID",
                table: "FBB_TBL_EVCUSTOMERINFO_DETAIL",
                column: "HEADER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_EVJOBAPPROVE_DETAIL_HEADER_ID",
                table: "FBB_TBL_EVJOBAPPROVE_DETAIL",
                column: "HEADER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_EVJOBINCOMPLETE_DETAIL_HEADER_ID",
                table: "FBB_TBL_EVJOBINCOMPLETE_DETAIL",
                column: "HEADER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_EVMICROSITE_DETAIL_HEADER_ID",
                table: "FBB_TBL_EVMICROSITE_DETAIL",
                column: "HEADER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_EVMICROSITEUPD_DETAIL_HEADER_ID",
                table: "FBB_TBL_EVMICROSITEUPD_DETAIL",
                column: "HEADER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_EVNOTIFYAPPOINTMENT_COMPANIES_ORDER_ID",
                table: "FBB_TBL_EVNOTIFYAPPOINTMENT_COMPANIES",
                column: "ORDER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_EVNOTIFYAPPOINTMENT_CRMS_ORDER_ID",
                table: "FBB_TBL_EVNOTIFYAPPOINTMENT_CRMS",
                column: "ORDER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_EVNOTIFYAPPOINTMENT_FEES_ORDER_ID",
                table: "FBB_TBL_EVNOTIFYAPPOINTMENT_FEES",
                column: "ORDER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_EVNOTIFYAPPOINTMENT_ONTOPS_ORDER_ID",
                table: "FBB_TBL_EVNOTIFYAPPOINTMENT_ONTOPS",
                column: "ORDER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_EVNOTIFYAPPOINTMENT_ORDER_HEADER_ID",
                table: "FBB_TBL_EVNOTIFYAPPOINTMENT_ORDER",
                column: "HEADER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_EVNOTIFYAPPOINTMENT_RESOURCE_ORDER_ID",
                table: "FBB_TBL_EVNOTIFYAPPOINTMENT_RESOURCE",
                column: "ORDER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_EVNOTIFYAPPOINTMENT_STAFFS_ORDER_ID",
                table: "FBB_TBL_EVNOTIFYAPPOINTMENT_STAFFS",
                column: "ORDER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_EVNOTIFYAPPOINTMENT_TEAMS_ORDER_ID",
                table: "FBB_TBL_EVNOTIFYAPPOINTMENT_TEAMS",
                column: "ORDER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_EVNOTIFYAPPOINTMENT_WFMS_ORDER_ID",
                table: "FBB_TBL_EVNOTIFYAPPOINTMENT_WFMS",
                column: "ORDER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_EVSENDCHECKLATE_DETAIL_HEADER_ID",
                table: "FBB_TBL_EVSENDCHECKLATE_DETAIL",
                column: "HEADER_ID");

            migrationBuilder.CreateIndex(
                name: "NonClusteredIndex-20210409-175036",
                table: "FBB_TBL_EXCEPTION_ERROR",
                column: "TRANSACTION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_MAPPING_EXTERNAL_MAPPING_WO",
                table: "FBB_TBL_MAPPING_EXTERNAL",
                column: "MAPPING_WO");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_MAPPING_PARAMETER_MAPPING_WO",
                table: "FBB_TBL_MAPPING_PARAMETER",
                column: "MAPPING_WO");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_MAPPING_VALIDATE_MAPPING_ID",
                table: "FBB_TBL_MAPPING_VALIDATE",
                column: "MAPPING_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_WO_ATTRIBUTE_WO_ID",
                table: "FBB_TBL_WO_ATTRIBUTE",
                column: "WO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_WO_BLAME_WO_ID",
                table: "FBB_TBL_WO_BLAME",
                column: "WO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_WO_ERROR_MESSAGE_WO_ID",
                table: "FBB_TBL_WO_ERROR_MESSAGE",
                column: "WO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_WO_SOA_COMPANIES_WO_ID",
                table: "FBB_TBL_WO_SOA_COMPANIES",
                column: "WO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_WO_SOA_CRMS_WO_ID",
                table: "FBB_TBL_WO_SOA_CRMS",
                column: "WO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_WO_SOA_FEES_WO_ID",
                table: "FBB_TBL_WO_SOA_FEES",
                column: "WO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_WO_SOA_HEADER_WO_ID",
                table: "FBB_TBL_WO_SOA_HEADER",
                column: "WO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_WO_SOA_INSTALL_ORDER_WO_ID",
                table: "FBB_TBL_WO_SOA_INSTALL_ORDER",
                column: "WO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_WO_SOA_MA_ORDER_WO_ID",
                table: "FBB_TBL_WO_SOA_MA_ORDER",
                column: "WO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_WO_SOA_ONTOPS_WO_ID",
                table: "FBB_TBL_WO_SOA_ONTOPS",
                column: "WO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_WO_SOA_RESOURCE_WO_ID",
                table: "FBB_TBL_WO_SOA_RESOURCE",
                column: "WO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_WO_SOA_STAFFS_WO_ID",
                table: "FBB_TBL_WO_SOA_STAFFS",
                column: "WO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_WO_SOA_TEAMS_WO_ID",
                table: "FBB_TBL_WO_SOA_TEAMS",
                column: "WO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FBB_TBL_WO_SOA_WFMS_WO_ID",
                table: "FBB_TBL_WO_SOA_WFMS",
                column: "WO_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FBB_TBL_EVAUTHORIZATION_DETAIL");

            migrationBuilder.DropTable(
                name: "FBB_TBL_EVAUTOAPPROVE_HEADER");

            migrationBuilder.DropTable(
                name: "FBB_TBL_EVCUSTOMERINFO_DETAIL");

            migrationBuilder.DropTable(
                name: "FBB_TBL_EVJOBAPPROVE_DETAIL");

            migrationBuilder.DropTable(
                name: "FBB_TBL_EVJOBINCOMPLETE_DETAIL");

            migrationBuilder.DropTable(
                name: "FBB_TBL_EVMICROSITE_DETAIL");

            migrationBuilder.DropTable(
                name: "FBB_TBL_EVMICROSITEUPD_DETAIL");

            migrationBuilder.DropTable(
                name: "FBB_TBL_EVNOTIFYAPPOINTMENT_COMPANIES");

            migrationBuilder.DropTable(
                name: "FBB_TBL_EVNOTIFYAPPOINTMENT_CRMS");

            migrationBuilder.DropTable(
                name: "FBB_TBL_EVNOTIFYAPPOINTMENT_FEES");

            migrationBuilder.DropTable(
                name: "FBB_TBL_EVNOTIFYAPPOINTMENT_ONTOPS");

            migrationBuilder.DropTable(
                name: "FBB_TBL_EVNOTIFYAPPOINTMENT_RESOURCE");

            migrationBuilder.DropTable(
                name: "FBB_TBL_EVNOTIFYAPPOINTMENT_STAFFS");

            migrationBuilder.DropTable(
                name: "FBB_TBL_EVNOTIFYAPPOINTMENT_TEAMS");

            migrationBuilder.DropTable(
                name: "FBB_TBL_EVNOTIFYAPPOINTMENT_WFMS");

            migrationBuilder.DropTable(
                name: "FBB_TBL_EVSENDCHECKLATE_DETAIL");

            migrationBuilder.DropTable(
                name: "FBB_TBL_EXCEPTION_ERROR");

            migrationBuilder.DropTable(
                name: "FBB_TBL_LIST_OF_VALUE");

            migrationBuilder.DropTable(
                name: "FBB_TBL_LOGGING");

            migrationBuilder.DropTable(
                name: "FBB_TBL_MAPPING_EXTERNAL");

            migrationBuilder.DropTable(
                name: "FBB_TBL_MAPPING_PARAMETER");

            migrationBuilder.DropTable(
                name: "FBB_TBL_MAPPING_VALIDATE");

            migrationBuilder.DropTable(
                name: "FBB_TBL_WO_ATTRIBUTE");

            migrationBuilder.DropTable(
                name: "FBB_TBL_WO_BLAME");

            migrationBuilder.DropTable(
                name: "FBB_TBL_WO_ERROR_MESSAGE");

            migrationBuilder.DropTable(
                name: "FBB_TBL_WO_SOA_COMPANIES");

            migrationBuilder.DropTable(
                name: "FBB_TBL_WO_SOA_CRMS");

            migrationBuilder.DropTable(
                name: "FBB_TBL_WO_SOA_FEES");

            migrationBuilder.DropTable(
                name: "FBB_TBL_WO_SOA_HEADER");

            migrationBuilder.DropTable(
                name: "FBB_TBL_WO_SOA_INSTALL_ORDER");

            migrationBuilder.DropTable(
                name: "FBB_TBL_WO_SOA_MA_ORDER");

            migrationBuilder.DropTable(
                name: "FBB_TBL_WO_SOA_ONTOPS");

            migrationBuilder.DropTable(
                name: "FBB_TBL_WO_SOA_RESOURCE");

            migrationBuilder.DropTable(
                name: "FBB_TBL_WO_SOA_STAFFS");

            migrationBuilder.DropTable(
                name: "FBB_TBL_WO_SOA_TEAMS");

            migrationBuilder.DropTable(
                name: "FBB_TBL_WO_SOA_WFMS");

            migrationBuilder.DropTable(
                name: "FBB_TBL_EVAUTHORIZATION_HEADER");

            migrationBuilder.DropTable(
                name: "FBB_TBL_EVCUSTOMERINFO_HEADER");

            migrationBuilder.DropTable(
                name: "FBB_TBL_EVJOBAPPROVE_HEADER");

            migrationBuilder.DropTable(
                name: "FBB_TBL_EVJOBINCOMPLETE_HEADER");

            migrationBuilder.DropTable(
                name: "FBB_TBL_EVMICROSITE_HEADER");

            migrationBuilder.DropTable(
                name: "FBB_TBL_EVMICROSITEUPD_HEADER");

            migrationBuilder.DropTable(
                name: "FBB_TBL_EVNOTIFYAPPOINTMENT_ORDER");

            migrationBuilder.DropTable(
                name: "FBB_TBL_EVSENDCHECKLATE_HEADER");

            migrationBuilder.DropTable(
                name: "FBB_TBL_MAPPING_WO");

            migrationBuilder.DropTable(
                name: "FBB_TBL_MAPPING_ID");

            migrationBuilder.DropTable(
                name: "FBB_TBL_WO");

            migrationBuilder.DropTable(
                name: "FBB_TBL_EVNOTIFYAPPOINTMENT_HEADER");

            migrationBuilder.DropSequence(
                name: "HEADERID_SEQ");

            migrationBuilder.DropSequence(
                name: "REFID_SEQ");
        }
    }
}
