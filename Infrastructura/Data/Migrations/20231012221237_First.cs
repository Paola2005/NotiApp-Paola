using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructura.Data.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Auditorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreUsuario = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescAccion = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auditorias", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EstadosNotificaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreEstado = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosNotificaciones", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Formatos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreFormato = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formatos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ModuloMaestros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreModulo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuloMaestros", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PermisoGenerico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombrePermiso = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermisoGenerico", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Radicados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radicados", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RespuestasNotificaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreTipo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RespuestasNotificaciones", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SubsModulos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreSubModulo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubsModulos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TiposNotificaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreTipo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposNotificaciones", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TiposRequerimientos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreRequerimiento = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposRequerimientos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RolsvsMaestros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdRol = table.Column<int>(type: "int", nullable: false),
                    RolesId = table.Column<int>(type: "int", nullable: true),
                    IdMaestro = table.Column<int>(type: "int", nullable: false),
                    ModuloMaestrosId = table.Column<int>(type: "int", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolsvsMaestros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolsvsMaestros_ModuloMaestros_ModuloMaestrosId",
                        column: x => x.ModuloMaestrosId,
                        principalTable: "ModuloMaestros",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RolsvsMaestros_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MaestrosvSubsModulos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdMaestro = table.Column<int>(type: "int", nullable: false),
                    ModuloMaestrosId = table.Column<int>(type: "int", nullable: true),
                    IdSubModulo = table.Column<int>(type: "int", nullable: false),
                    SubsModulosId = table.Column<int>(type: "int", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaestrosvSubsModulos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaestrosvSubsModulos_ModuloMaestros_ModuloMaestrosId",
                        column: x => x.ModuloMaestrosId,
                        principalTable: "ModuloMaestros",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MaestrosvSubsModulos_SubsModulos_SubsModulosId",
                        column: x => x.SubsModulosId,
                        principalTable: "SubsModulos",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BlockChains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdNotificacion = table.Column<int>(type: "int", nullable: false),
                    TiposNotificacionesId = table.Column<int>(type: "int", nullable: true),
                    IdHiloRespuesta = table.Column<int>(type: "int", nullable: false),
                    RespuestasNotificacionesId = table.Column<int>(type: "int", nullable: true),
                    IdAuditoria = table.Column<int>(type: "int", nullable: false),
                    AuditoriasId = table.Column<int>(type: "int", nullable: true),
                    HashGenerado = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlockChains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlockChains_Auditorias_AuditoriasId",
                        column: x => x.AuditoriasId,
                        principalTable: "Auditorias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BlockChains_RespuestasNotificaciones_RespuestasNotificacione~",
                        column: x => x.RespuestasNotificacionesId,
                        principalTable: "RespuestasNotificaciones",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BlockChains_TiposNotificaciones_TiposNotificacionesId",
                        column: x => x.TiposNotificacionesId,
                        principalTable: "TiposNotificaciones",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ModulosNotificaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AsuntoNotificacion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoNotificacion = table.Column<int>(type: "int", nullable: false),
                    TiposNotificacionesId = table.Column<int>(type: "int", nullable: true),
                    IdRadicado = table.Column<int>(type: "int", nullable: false),
                    RadicadosId = table.Column<int>(type: "int", nullable: true),
                    IdEstadoNotificacion = table.Column<int>(type: "int", nullable: false),
                    EstadosNotificacionesId = table.Column<int>(type: "int", nullable: true),
                    IdHiloRespuesta = table.Column<int>(type: "int", nullable: false),
                    RespuestasNotificacionesId = table.Column<int>(type: "int", nullable: true),
                    IdFromato = table.Column<int>(type: "int", nullable: false),
                    FormatosId = table.Column<int>(type: "int", nullable: true),
                    IdRequerimiento = table.Column<int>(type: "int", nullable: false),
                    TiposRequerimientosId = table.Column<int>(type: "int", nullable: true),
                    TextoNotificacion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModulosNotificaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModulosNotificaciones_EstadosNotificaciones_EstadosNotificac~",
                        column: x => x.EstadosNotificacionesId,
                        principalTable: "EstadosNotificaciones",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ModulosNotificaciones_Formatos_FormatosId",
                        column: x => x.FormatosId,
                        principalTable: "Formatos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ModulosNotificaciones_Radicados_RadicadosId",
                        column: x => x.RadicadosId,
                        principalTable: "Radicados",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ModulosNotificaciones_RespuestasNotificaciones_RespuestasNot~",
                        column: x => x.RespuestasNotificacionesId,
                        principalTable: "RespuestasNotificaciones",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ModulosNotificaciones_TiposNotificaciones_TiposNotificacione~",
                        column: x => x.TiposNotificacionesId,
                        principalTable: "TiposNotificaciones",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ModulosNotificaciones_TiposRequerimientos_TiposRequerimiento~",
                        column: x => x.TiposRequerimientosId,
                        principalTable: "TiposRequerimientos",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GenericossvSubsModulos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdGenericos = table.Column<int>(type: "int", nullable: false),
                    PermisoGenericoId = table.Column<int>(type: "int", nullable: true),
                    IdSubModulos = table.Column<int>(type: "int", nullable: false),
                    MaestrosvSubsModulosId = table.Column<int>(type: "int", nullable: true),
                    IdRol = table.Column<int>(type: "int", nullable: false),
                    RolesId = table.Column<int>(type: "int", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenericossvSubsModulos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenericossvSubsModulos_MaestrosvSubsModulos_MaestrosvSubsMod~",
                        column: x => x.MaestrosvSubsModulosId,
                        principalTable: "MaestrosvSubsModulos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GenericossvSubsModulos_PermisoGenerico_PermisoGenericoId",
                        column: x => x.PermisoGenericoId,
                        principalTable: "PermisoGenerico",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GenericossvSubsModulos_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_BlockChains_AuditoriasId",
                table: "BlockChains",
                column: "AuditoriasId");

            migrationBuilder.CreateIndex(
                name: "IX_BlockChains_RespuestasNotificacionesId",
                table: "BlockChains",
                column: "RespuestasNotificacionesId");

            migrationBuilder.CreateIndex(
                name: "IX_BlockChains_TiposNotificacionesId",
                table: "BlockChains",
                column: "TiposNotificacionesId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericossvSubsModulos_MaestrosvSubsModulosId",
                table: "GenericossvSubsModulos",
                column: "MaestrosvSubsModulosId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericossvSubsModulos_PermisoGenericoId",
                table: "GenericossvSubsModulos",
                column: "PermisoGenericoId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericossvSubsModulos_RolesId",
                table: "GenericossvSubsModulos",
                column: "RolesId");

            migrationBuilder.CreateIndex(
                name: "IX_MaestrosvSubsModulos_ModuloMaestrosId",
                table: "MaestrosvSubsModulos",
                column: "ModuloMaestrosId");

            migrationBuilder.CreateIndex(
                name: "IX_MaestrosvSubsModulos_SubsModulosId",
                table: "MaestrosvSubsModulos",
                column: "SubsModulosId");

            migrationBuilder.CreateIndex(
                name: "IX_ModulosNotificaciones_EstadosNotificacionesId",
                table: "ModulosNotificaciones",
                column: "EstadosNotificacionesId");

            migrationBuilder.CreateIndex(
                name: "IX_ModulosNotificaciones_FormatosId",
                table: "ModulosNotificaciones",
                column: "FormatosId");

            migrationBuilder.CreateIndex(
                name: "IX_ModulosNotificaciones_RadicadosId",
                table: "ModulosNotificaciones",
                column: "RadicadosId");

            migrationBuilder.CreateIndex(
                name: "IX_ModulosNotificaciones_RespuestasNotificacionesId",
                table: "ModulosNotificaciones",
                column: "RespuestasNotificacionesId");

            migrationBuilder.CreateIndex(
                name: "IX_ModulosNotificaciones_TiposNotificacionesId",
                table: "ModulosNotificaciones",
                column: "TiposNotificacionesId");

            migrationBuilder.CreateIndex(
                name: "IX_ModulosNotificaciones_TiposRequerimientosId",
                table: "ModulosNotificaciones",
                column: "TiposRequerimientosId");

            migrationBuilder.CreateIndex(
                name: "IX_RolsvsMaestros_ModuloMaestrosId",
                table: "RolsvsMaestros",
                column: "ModuloMaestrosId");

            migrationBuilder.CreateIndex(
                name: "IX_RolsvsMaestros_RolesId",
                table: "RolsvsMaestros",
                column: "RolesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlockChains");

            migrationBuilder.DropTable(
                name: "GenericossvSubsModulos");

            migrationBuilder.DropTable(
                name: "ModulosNotificaciones");

            migrationBuilder.DropTable(
                name: "RolsvsMaestros");

            migrationBuilder.DropTable(
                name: "Auditorias");

            migrationBuilder.DropTable(
                name: "MaestrosvSubsModulos");

            migrationBuilder.DropTable(
                name: "PermisoGenerico");

            migrationBuilder.DropTable(
                name: "EstadosNotificaciones");

            migrationBuilder.DropTable(
                name: "Formatos");

            migrationBuilder.DropTable(
                name: "Radicados");

            migrationBuilder.DropTable(
                name: "RespuestasNotificaciones");

            migrationBuilder.DropTable(
                name: "TiposNotificaciones");

            migrationBuilder.DropTable(
                name: "TiposRequerimientos");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "ModuloMaestros");

            migrationBuilder.DropTable(
                name: "SubsModulos");
        }
    }
}
