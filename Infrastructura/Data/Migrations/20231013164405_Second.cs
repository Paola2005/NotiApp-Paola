using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructura.Data.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlockChains_Auditorias_AuditoriasId",
                table: "BlockChains");

            migrationBuilder.DropForeignKey(
                name: "FK_BlockChains_RespuestasNotificaciones_RespuestasNotificacione~",
                table: "BlockChains");

            migrationBuilder.DropForeignKey(
                name: "FK_BlockChains_TiposNotificaciones_TiposNotificacionesId",
                table: "BlockChains");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericossvSubsModulos_MaestrosvSubsModulos_MaestrosvSubsMod~",
                table: "GenericossvSubsModulos");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericossvSubsModulos_PermisoGenerico_PermisoGenericoId",
                table: "GenericossvSubsModulos");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericossvSubsModulos_Roles_RolesId",
                table: "GenericossvSubsModulos");

            migrationBuilder.DropForeignKey(
                name: "FK_MaestrosvSubsModulos_ModuloMaestros_ModuloMaestrosId",
                table: "MaestrosvSubsModulos");

            migrationBuilder.DropForeignKey(
                name: "FK_MaestrosvSubsModulos_SubsModulos_SubsModulosId",
                table: "MaestrosvSubsModulos");

            migrationBuilder.DropForeignKey(
                name: "FK_ModulosNotificaciones_EstadosNotificaciones_EstadosNotificac~",
                table: "ModulosNotificaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_ModulosNotificaciones_Formatos_FormatosId",
                table: "ModulosNotificaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_ModulosNotificaciones_Radicados_RadicadosId",
                table: "ModulosNotificaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_ModulosNotificaciones_RespuestasNotificaciones_RespuestasNot~",
                table: "ModulosNotificaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_ModulosNotificaciones_TiposNotificaciones_TiposNotificacione~",
                table: "ModulosNotificaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_ModulosNotificaciones_TiposRequerimientos_TiposRequerimiento~",
                table: "ModulosNotificaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_RolsvsMaestros_ModuloMaestros_ModuloMaestrosId",
                table: "RolsvsMaestros");

            migrationBuilder.DropForeignKey(
                name: "FK_RolsvsMaestros_Roles_RolesId",
                table: "RolsvsMaestros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposRequerimientos",
                table: "TiposRequerimientos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposNotificaciones",
                table: "TiposNotificaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubsModulos",
                table: "SubsModulos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RolsvsMaestros",
                table: "RolsvsMaestros");

            migrationBuilder.DropIndex(
                name: "IX_RolsvsMaestros_ModuloMaestrosId",
                table: "RolsvsMaestros");

            migrationBuilder.DropIndex(
                name: "IX_RolsvsMaestros_RolesId",
                table: "RolsvsMaestros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RespuestasNotificaciones",
                table: "RespuestasNotificaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Radicados",
                table: "Radicados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PermisoGenerico",
                table: "PermisoGenerico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ModulosNotificaciones",
                table: "ModulosNotificaciones");

            migrationBuilder.DropIndex(
                name: "IX_ModulosNotificaciones_EstadosNotificacionesId",
                table: "ModulosNotificaciones");

            migrationBuilder.DropIndex(
                name: "IX_ModulosNotificaciones_FormatosId",
                table: "ModulosNotificaciones");

            migrationBuilder.DropIndex(
                name: "IX_ModulosNotificaciones_RadicadosId",
                table: "ModulosNotificaciones");

            migrationBuilder.DropIndex(
                name: "IX_ModulosNotificaciones_RespuestasNotificacionesId",
                table: "ModulosNotificaciones");

            migrationBuilder.DropIndex(
                name: "IX_ModulosNotificaciones_TiposNotificacionesId",
                table: "ModulosNotificaciones");

            migrationBuilder.DropIndex(
                name: "IX_ModulosNotificaciones_TiposRequerimientosId",
                table: "ModulosNotificaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ModuloMaestros",
                table: "ModuloMaestros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaestrosvSubsModulos",
                table: "MaestrosvSubsModulos");

            migrationBuilder.DropIndex(
                name: "IX_MaestrosvSubsModulos_ModuloMaestrosId",
                table: "MaestrosvSubsModulos");

            migrationBuilder.DropIndex(
                name: "IX_MaestrosvSubsModulos_SubsModulosId",
                table: "MaestrosvSubsModulos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GenericossvSubsModulos",
                table: "GenericossvSubsModulos");

            migrationBuilder.DropIndex(
                name: "IX_GenericossvSubsModulos_MaestrosvSubsModulosId",
                table: "GenericossvSubsModulos");

            migrationBuilder.DropIndex(
                name: "IX_GenericossvSubsModulos_PermisoGenericoId",
                table: "GenericossvSubsModulos");

            migrationBuilder.DropIndex(
                name: "IX_GenericossvSubsModulos_RolesId",
                table: "GenericossvSubsModulos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Formatos",
                table: "Formatos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstadosNotificaciones",
                table: "EstadosNotificaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlockChains",
                table: "BlockChains");

            migrationBuilder.DropIndex(
                name: "IX_BlockChains_AuditoriasId",
                table: "BlockChains");

            migrationBuilder.DropIndex(
                name: "IX_BlockChains_RespuestasNotificacionesId",
                table: "BlockChains");

            migrationBuilder.DropIndex(
                name: "IX_BlockChains_TiposNotificacionesId",
                table: "BlockChains");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Auditorias",
                table: "Auditorias");

            migrationBuilder.DropColumn(
                name: "ModuloMaestrosId",
                table: "RolsvsMaestros");

            migrationBuilder.DropColumn(
                name: "RolesId",
                table: "RolsvsMaestros");

            migrationBuilder.DropColumn(
                name: "EstadosNotificacionesId",
                table: "ModulosNotificaciones");

            migrationBuilder.DropColumn(
                name: "FormatosId",
                table: "ModulosNotificaciones");

            migrationBuilder.DropColumn(
                name: "RadicadosId",
                table: "ModulosNotificaciones");

            migrationBuilder.DropColumn(
                name: "RespuestasNotificacionesId",
                table: "ModulosNotificaciones");

            migrationBuilder.DropColumn(
                name: "TiposNotificacionesId",
                table: "ModulosNotificaciones");

            migrationBuilder.DropColumn(
                name: "TiposRequerimientosId",
                table: "ModulosNotificaciones");

            migrationBuilder.DropColumn(
                name: "ModuloMaestrosId",
                table: "MaestrosvSubsModulos");

            migrationBuilder.DropColumn(
                name: "SubsModulosId",
                table: "MaestrosvSubsModulos");

            migrationBuilder.DropColumn(
                name: "MaestrosvSubsModulosId",
                table: "GenericossvSubsModulos");

            migrationBuilder.DropColumn(
                name: "PermisoGenericoId",
                table: "GenericossvSubsModulos");

            migrationBuilder.DropColumn(
                name: "RolesId",
                table: "GenericossvSubsModulos");

            migrationBuilder.DropColumn(
                name: "AuditoriasId",
                table: "BlockChains");

            migrationBuilder.DropColumn(
                name: "RespuestasNotificacionesId",
                table: "BlockChains");

            migrationBuilder.DropColumn(
                name: "TiposNotificacionesId",
                table: "BlockChains");

            migrationBuilder.RenameTable(
                name: "TiposRequerimientos",
                newName: "TipoRequerimiento");

            migrationBuilder.RenameTable(
                name: "TiposNotificaciones",
                newName: "TipoNotificacion");

            migrationBuilder.RenameTable(
                name: "SubsModulos",
                newName: "SubModulos");

            migrationBuilder.RenameTable(
                name: "RolsvsMaestros",
                newName: "RolvsMaestro");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "Rol");

            migrationBuilder.RenameTable(
                name: "RespuestasNotificaciones",
                newName: "RespuestaNotificacion");

            migrationBuilder.RenameTable(
                name: "Radicados",
                newName: "Radicado");

            migrationBuilder.RenameTable(
                name: "PermisoGenerico",
                newName: "PermisosGenericos");

            migrationBuilder.RenameTable(
                name: "ModulosNotificaciones",
                newName: "ModuloNotificacion");

            migrationBuilder.RenameTable(
                name: "ModuloMaestros",
                newName: "ModulosMaestros");

            migrationBuilder.RenameTable(
                name: "MaestrosvSubsModulos",
                newName: "MaestrosvSubModulos");

            migrationBuilder.RenameTable(
                name: "GenericossvSubsModulos",
                newName: "GenericosVSSubModulos");

            migrationBuilder.RenameTable(
                name: "Formatos",
                newName: "Formato");

            migrationBuilder.RenameTable(
                name: "EstadosNotificaciones",
                newName: "EstadoNotificacion");

            migrationBuilder.RenameTable(
                name: "BlockChains",
                newName: "BlockChain");

            migrationBuilder.RenameTable(
                name: "Auditorias",
                newName: "Auditoria");

            migrationBuilder.AlterColumn<string>(
                name: "NombreRequerimiento",
                table: "TipoRequerimiento",
                type: "varchar(80)",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NombreTipo",
                table: "TipoNotificacion",
                type: "varchar(80)",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NombreSubModulo",
                table: "SubModulos",
                type: "varchar(80)",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Rol",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NombreTipo",
                table: "RespuestaNotificacion",
                type: "varchar(80)",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NombrePermiso",
                table: "PermisosGenericos",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "TextoNotificacion",
                table: "ModuloNotificacion",
                type: "varchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "AsuntoNotificacion",
                table: "ModuloNotificacion",
                type: "varchar(80)",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NombreModulo",
                table: "ModulosMaestros",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "MaestrosvSubModulos",
                table: "ModulosMaestros",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NombreFormato",
                table: "Formato",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NombreEstado",
                table: "EstadoNotificacion",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "HashGenerado",
                table: "BlockChain",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NombreUsuario",
                table: "Auditoria",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoRequerimiento",
                table: "TipoRequerimiento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoNotificacion",
                table: "TipoNotificacion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubModulos",
                table: "SubModulos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RolvsMaestro",
                table: "RolvsMaestro",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rol",
                table: "Rol",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RespuestaNotificacion",
                table: "RespuestaNotificacion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Radicado",
                table: "Radicado",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PermisosGenericos",
                table: "PermisosGenericos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ModuloNotificacion",
                table: "ModuloNotificacion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ModulosMaestros",
                table: "ModulosMaestros",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaestrosvSubModulos",
                table: "MaestrosvSubModulos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GenericosVSSubModulos",
                table: "GenericosVSSubModulos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Formato",
                table: "Formato",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstadoNotificacion",
                table: "EstadoNotificacion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlockChain",
                table: "BlockChain",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Auditoria",
                table: "Auditoria",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_RolvsMaestro_IdMaestro",
                table: "RolvsMaestro",
                column: "IdMaestro");

            migrationBuilder.CreateIndex(
                name: "IX_RolvsMaestro_IdRol",
                table: "RolvsMaestro",
                column: "IdRol");

            migrationBuilder.CreateIndex(
                name: "IX_ModuloNotificacion_IdEstadoNotificacion",
                table: "ModuloNotificacion",
                column: "IdEstadoNotificacion");

            migrationBuilder.CreateIndex(
                name: "IX_ModuloNotificacion_IdFromato",
                table: "ModuloNotificacion",
                column: "IdFromato");

            migrationBuilder.CreateIndex(
                name: "IX_ModuloNotificacion_IdHiloRespuesta",
                table: "ModuloNotificacion",
                column: "IdHiloRespuesta");

            migrationBuilder.CreateIndex(
                name: "IX_ModuloNotificacion_IdRadicado",
                table: "ModuloNotificacion",
                column: "IdRadicado");

            migrationBuilder.CreateIndex(
                name: "IX_ModuloNotificacion_IdRequerimiento",
                table: "ModuloNotificacion",
                column: "IdRequerimiento");

            migrationBuilder.CreateIndex(
                name: "IX_ModuloNotificacion_IdTipoNotificacion",
                table: "ModuloNotificacion",
                column: "IdTipoNotificacion");

            migrationBuilder.CreateIndex(
                name: "IX_MaestrosvSubModulos_IdMaestro",
                table: "MaestrosvSubModulos",
                column: "IdMaestro");

            migrationBuilder.CreateIndex(
                name: "IX_MaestrosvSubModulos_IdSubModulo",
                table: "MaestrosvSubModulos",
                column: "IdSubModulo");

            migrationBuilder.CreateIndex(
                name: "IX_GenericosVSSubModulos_IdGenericos",
                table: "GenericosVSSubModulos",
                column: "IdGenericos");

            migrationBuilder.CreateIndex(
                name: "IX_GenericosVSSubModulos_IdRol",
                table: "GenericosVSSubModulos",
                column: "IdRol");

            migrationBuilder.CreateIndex(
                name: "IX_GenericosVSSubModulos_IdSubModulos",
                table: "GenericosVSSubModulos",
                column: "IdSubModulos");

            migrationBuilder.CreateIndex(
                name: "IX_BlockChain_IdAuditoria",
                table: "BlockChain",
                column: "IdAuditoria");

            migrationBuilder.CreateIndex(
                name: "IX_BlockChain_IdHiloRespuesta",
                table: "BlockChain",
                column: "IdHiloRespuesta");

            migrationBuilder.CreateIndex(
                name: "IX_BlockChain_IdNotificacion",
                table: "BlockChain",
                column: "IdNotificacion");

            migrationBuilder.AddForeignKey(
                name: "FK_BlockChain_Auditoria_IdAuditoria",
                table: "BlockChain",
                column: "IdAuditoria",
                principalTable: "Auditoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlockChain_RespuestaNotificacion_IdHiloRespuesta",
                table: "BlockChain",
                column: "IdHiloRespuesta",
                principalTable: "RespuestaNotificacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlockChain_TipoNotificacion_IdNotificacion",
                table: "BlockChain",
                column: "IdNotificacion",
                principalTable: "TipoNotificacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GenericosVSSubModulos_MaestrosvSubModulos_IdSubModulos",
                table: "GenericosVSSubModulos",
                column: "IdSubModulos",
                principalTable: "MaestrosvSubModulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GenericosVSSubModulos_PermisosGenericos_IdGenericos",
                table: "GenericosVSSubModulos",
                column: "IdGenericos",
                principalTable: "PermisosGenericos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GenericosVSSubModulos_Rol_IdRol",
                table: "GenericosVSSubModulos",
                column: "IdRol",
                principalTable: "Rol",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaestrosvSubModulos_ModulosMaestros_IdMaestro",
                table: "MaestrosvSubModulos",
                column: "IdMaestro",
                principalTable: "ModulosMaestros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaestrosvSubModulos_SubModulos_IdSubModulo",
                table: "MaestrosvSubModulos",
                column: "IdSubModulo",
                principalTable: "SubModulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuloNotificacion_EstadoNotificacion_IdEstadoNotificacion",
                table: "ModuloNotificacion",
                column: "IdEstadoNotificacion",
                principalTable: "EstadoNotificacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuloNotificacion_Formato_IdFromato",
                table: "ModuloNotificacion",
                column: "IdFromato",
                principalTable: "Formato",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuloNotificacion_Radicado_IdRadicado",
                table: "ModuloNotificacion",
                column: "IdRadicado",
                principalTable: "Radicado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuloNotificacion_RespuestaNotificacion_IdHiloRespuesta",
                table: "ModuloNotificacion",
                column: "IdHiloRespuesta",
                principalTable: "RespuestaNotificacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuloNotificacion_TipoNotificacion_IdTipoNotificacion",
                table: "ModuloNotificacion",
                column: "IdTipoNotificacion",
                principalTable: "TipoNotificacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModuloNotificacion_TipoRequerimiento_IdRequerimiento",
                table: "ModuloNotificacion",
                column: "IdRequerimiento",
                principalTable: "TipoRequerimiento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RolvsMaestro_ModulosMaestros_IdMaestro",
                table: "RolvsMaestro",
                column: "IdMaestro",
                principalTable: "ModulosMaestros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RolvsMaestro_Rol_IdRol",
                table: "RolvsMaestro",
                column: "IdRol",
                principalTable: "Rol",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlockChain_Auditoria_IdAuditoria",
                table: "BlockChain");

            migrationBuilder.DropForeignKey(
                name: "FK_BlockChain_RespuestaNotificacion_IdHiloRespuesta",
                table: "BlockChain");

            migrationBuilder.DropForeignKey(
                name: "FK_BlockChain_TipoNotificacion_IdNotificacion",
                table: "BlockChain");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericosVSSubModulos_MaestrosvSubModulos_IdSubModulos",
                table: "GenericosVSSubModulos");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericosVSSubModulos_PermisosGenericos_IdGenericos",
                table: "GenericosVSSubModulos");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericosVSSubModulos_Rol_IdRol",
                table: "GenericosVSSubModulos");

            migrationBuilder.DropForeignKey(
                name: "FK_MaestrosvSubModulos_ModulosMaestros_IdMaestro",
                table: "MaestrosvSubModulos");

            migrationBuilder.DropForeignKey(
                name: "FK_MaestrosvSubModulos_SubModulos_IdSubModulo",
                table: "MaestrosvSubModulos");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuloNotificacion_EstadoNotificacion_IdEstadoNotificacion",
                table: "ModuloNotificacion");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuloNotificacion_Formato_IdFromato",
                table: "ModuloNotificacion");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuloNotificacion_Radicado_IdRadicado",
                table: "ModuloNotificacion");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuloNotificacion_RespuestaNotificacion_IdHiloRespuesta",
                table: "ModuloNotificacion");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuloNotificacion_TipoNotificacion_IdTipoNotificacion",
                table: "ModuloNotificacion");

            migrationBuilder.DropForeignKey(
                name: "FK_ModuloNotificacion_TipoRequerimiento_IdRequerimiento",
                table: "ModuloNotificacion");

            migrationBuilder.DropForeignKey(
                name: "FK_RolvsMaestro_ModulosMaestros_IdMaestro",
                table: "RolvsMaestro");

            migrationBuilder.DropForeignKey(
                name: "FK_RolvsMaestro_Rol_IdRol",
                table: "RolvsMaestro");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoRequerimiento",
                table: "TipoRequerimiento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoNotificacion",
                table: "TipoNotificacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubModulos",
                table: "SubModulos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RolvsMaestro",
                table: "RolvsMaestro");

            migrationBuilder.DropIndex(
                name: "IX_RolvsMaestro_IdMaestro",
                table: "RolvsMaestro");

            migrationBuilder.DropIndex(
                name: "IX_RolvsMaestro_IdRol",
                table: "RolvsMaestro");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rol",
                table: "Rol");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RespuestaNotificacion",
                table: "RespuestaNotificacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Radicado",
                table: "Radicado");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PermisosGenericos",
                table: "PermisosGenericos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ModulosMaestros",
                table: "ModulosMaestros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ModuloNotificacion",
                table: "ModuloNotificacion");

            migrationBuilder.DropIndex(
                name: "IX_ModuloNotificacion_IdEstadoNotificacion",
                table: "ModuloNotificacion");

            migrationBuilder.DropIndex(
                name: "IX_ModuloNotificacion_IdFromato",
                table: "ModuloNotificacion");

            migrationBuilder.DropIndex(
                name: "IX_ModuloNotificacion_IdHiloRespuesta",
                table: "ModuloNotificacion");

            migrationBuilder.DropIndex(
                name: "IX_ModuloNotificacion_IdRadicado",
                table: "ModuloNotificacion");

            migrationBuilder.DropIndex(
                name: "IX_ModuloNotificacion_IdRequerimiento",
                table: "ModuloNotificacion");

            migrationBuilder.DropIndex(
                name: "IX_ModuloNotificacion_IdTipoNotificacion",
                table: "ModuloNotificacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaestrosvSubModulos",
                table: "MaestrosvSubModulos");

            migrationBuilder.DropIndex(
                name: "IX_MaestrosvSubModulos_IdMaestro",
                table: "MaestrosvSubModulos");

            migrationBuilder.DropIndex(
                name: "IX_MaestrosvSubModulos_IdSubModulo",
                table: "MaestrosvSubModulos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GenericosVSSubModulos",
                table: "GenericosVSSubModulos");

            migrationBuilder.DropIndex(
                name: "IX_GenericosVSSubModulos_IdGenericos",
                table: "GenericosVSSubModulos");

            migrationBuilder.DropIndex(
                name: "IX_GenericosVSSubModulos_IdRol",
                table: "GenericosVSSubModulos");

            migrationBuilder.DropIndex(
                name: "IX_GenericosVSSubModulos_IdSubModulos",
                table: "GenericosVSSubModulos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Formato",
                table: "Formato");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstadoNotificacion",
                table: "EstadoNotificacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlockChain",
                table: "BlockChain");

            migrationBuilder.DropIndex(
                name: "IX_BlockChain_IdAuditoria",
                table: "BlockChain");

            migrationBuilder.DropIndex(
                name: "IX_BlockChain_IdHiloRespuesta",
                table: "BlockChain");

            migrationBuilder.DropIndex(
                name: "IX_BlockChain_IdNotificacion",
                table: "BlockChain");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Auditoria",
                table: "Auditoria");

            migrationBuilder.DropColumn(
                name: "MaestrosvSubModulos",
                table: "ModulosMaestros");

            migrationBuilder.RenameTable(
                name: "TipoRequerimiento",
                newName: "TiposRequerimientos");

            migrationBuilder.RenameTable(
                name: "TipoNotificacion",
                newName: "TiposNotificaciones");

            migrationBuilder.RenameTable(
                name: "SubModulos",
                newName: "SubsModulos");

            migrationBuilder.RenameTable(
                name: "RolvsMaestro",
                newName: "RolsvsMaestros");

            migrationBuilder.RenameTable(
                name: "Rol",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "RespuestaNotificacion",
                newName: "RespuestasNotificaciones");

            migrationBuilder.RenameTable(
                name: "Radicado",
                newName: "Radicados");

            migrationBuilder.RenameTable(
                name: "PermisosGenericos",
                newName: "PermisoGenerico");

            migrationBuilder.RenameTable(
                name: "ModulosMaestros",
                newName: "ModuloMaestros");

            migrationBuilder.RenameTable(
                name: "ModuloNotificacion",
                newName: "ModulosNotificaciones");

            migrationBuilder.RenameTable(
                name: "MaestrosvSubModulos",
                newName: "MaestrosvSubsModulos");

            migrationBuilder.RenameTable(
                name: "GenericosVSSubModulos",
                newName: "GenericossvSubsModulos");

            migrationBuilder.RenameTable(
                name: "Formato",
                newName: "Formatos");

            migrationBuilder.RenameTable(
                name: "EstadoNotificacion",
                newName: "EstadosNotificaciones");

            migrationBuilder.RenameTable(
                name: "BlockChain",
                newName: "BlockChains");

            migrationBuilder.RenameTable(
                name: "Auditoria",
                newName: "Auditorias");

            migrationBuilder.AlterColumn<string>(
                name: "NombreRequerimiento",
                table: "TiposRequerimientos",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldMaxLength: 80,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NombreTipo",
                table: "TiposNotificaciones",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldMaxLength: 80,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NombreSubModulo",
                table: "SubsModulos",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldMaxLength: 80,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "ModuloMaestrosId",
                table: "RolsvsMaestros",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RolesId",
                table: "RolsvsMaestros",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Roles",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NombreTipo",
                table: "RespuestasNotificaciones",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldMaxLength: 80,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NombrePermiso",
                table: "PermisoGenerico",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NombreModulo",
                table: "ModuloMaestros",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "TextoNotificacion",
                table: "ModulosNotificaciones",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "AsuntoNotificacion",
                table: "ModulosNotificaciones",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldMaxLength: 80,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "EstadosNotificacionesId",
                table: "ModulosNotificaciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FormatosId",
                table: "ModulosNotificaciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RadicadosId",
                table: "ModulosNotificaciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RespuestasNotificacionesId",
                table: "ModulosNotificaciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TiposNotificacionesId",
                table: "ModulosNotificaciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TiposRequerimientosId",
                table: "ModulosNotificaciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModuloMaestrosId",
                table: "MaestrosvSubsModulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubsModulosId",
                table: "MaestrosvSubsModulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaestrosvSubsModulosId",
                table: "GenericossvSubsModulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PermisoGenericoId",
                table: "GenericossvSubsModulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RolesId",
                table: "GenericossvSubsModulos",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NombreFormato",
                table: "Formatos",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NombreEstado",
                table: "EstadosNotificaciones",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "HashGenerado",
                table: "BlockChains",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "AuditoriasId",
                table: "BlockChains",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RespuestasNotificacionesId",
                table: "BlockChains",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TiposNotificacionesId",
                table: "BlockChains",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NombreUsuario",
                table: "Auditorias",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposRequerimientos",
                table: "TiposRequerimientos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposNotificaciones",
                table: "TiposNotificaciones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubsModulos",
                table: "SubsModulos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RolsvsMaestros",
                table: "RolsvsMaestros",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RespuestasNotificaciones",
                table: "RespuestasNotificaciones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Radicados",
                table: "Radicados",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PermisoGenerico",
                table: "PermisoGenerico",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ModuloMaestros",
                table: "ModuloMaestros",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ModulosNotificaciones",
                table: "ModulosNotificaciones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaestrosvSubsModulos",
                table: "MaestrosvSubsModulos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GenericossvSubsModulos",
                table: "GenericossvSubsModulos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Formatos",
                table: "Formatos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstadosNotificaciones",
                table: "EstadosNotificaciones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlockChains",
                table: "BlockChains",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Auditorias",
                table: "Auditorias",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_RolsvsMaestros_ModuloMaestrosId",
                table: "RolsvsMaestros",
                column: "ModuloMaestrosId");

            migrationBuilder.CreateIndex(
                name: "IX_RolsvsMaestros_RolesId",
                table: "RolsvsMaestros",
                column: "RolesId");

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
                name: "IX_MaestrosvSubsModulos_ModuloMaestrosId",
                table: "MaestrosvSubsModulos",
                column: "ModuloMaestrosId");

            migrationBuilder.CreateIndex(
                name: "IX_MaestrosvSubsModulos_SubsModulosId",
                table: "MaestrosvSubsModulos",
                column: "SubsModulosId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_BlockChains_Auditorias_AuditoriasId",
                table: "BlockChains",
                column: "AuditoriasId",
                principalTable: "Auditorias",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BlockChains_RespuestasNotificaciones_RespuestasNotificacione~",
                table: "BlockChains",
                column: "RespuestasNotificacionesId",
                principalTable: "RespuestasNotificaciones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BlockChains_TiposNotificaciones_TiposNotificacionesId",
                table: "BlockChains",
                column: "TiposNotificacionesId",
                principalTable: "TiposNotificaciones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericossvSubsModulos_MaestrosvSubsModulos_MaestrosvSubsMod~",
                table: "GenericossvSubsModulos",
                column: "MaestrosvSubsModulosId",
                principalTable: "MaestrosvSubsModulos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericossvSubsModulos_PermisoGenerico_PermisoGenericoId",
                table: "GenericossvSubsModulos",
                column: "PermisoGenericoId",
                principalTable: "PermisoGenerico",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericossvSubsModulos_Roles_RolesId",
                table: "GenericossvSubsModulos",
                column: "RolesId",
                principalTable: "Roles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MaestrosvSubsModulos_ModuloMaestros_ModuloMaestrosId",
                table: "MaestrosvSubsModulos",
                column: "ModuloMaestrosId",
                principalTable: "ModuloMaestros",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MaestrosvSubsModulos_SubsModulos_SubsModulosId",
                table: "MaestrosvSubsModulos",
                column: "SubsModulosId",
                principalTable: "SubsModulos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ModulosNotificaciones_EstadosNotificaciones_EstadosNotificac~",
                table: "ModulosNotificaciones",
                column: "EstadosNotificacionesId",
                principalTable: "EstadosNotificaciones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ModulosNotificaciones_Formatos_FormatosId",
                table: "ModulosNotificaciones",
                column: "FormatosId",
                principalTable: "Formatos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ModulosNotificaciones_Radicados_RadicadosId",
                table: "ModulosNotificaciones",
                column: "RadicadosId",
                principalTable: "Radicados",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ModulosNotificaciones_RespuestasNotificaciones_RespuestasNot~",
                table: "ModulosNotificaciones",
                column: "RespuestasNotificacionesId",
                principalTable: "RespuestasNotificaciones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ModulosNotificaciones_TiposNotificaciones_TiposNotificacione~",
                table: "ModulosNotificaciones",
                column: "TiposNotificacionesId",
                principalTable: "TiposNotificaciones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ModulosNotificaciones_TiposRequerimientos_TiposRequerimiento~",
                table: "ModulosNotificaciones",
                column: "TiposRequerimientosId",
                principalTable: "TiposRequerimientos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RolsvsMaestros_ModuloMaestros_ModuloMaestrosId",
                table: "RolsvsMaestros",
                column: "ModuloMaestrosId",
                principalTable: "ModuloMaestros",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RolsvsMaestros_Roles_RolesId",
                table: "RolsvsMaestros",
                column: "RolesId",
                principalTable: "Roles",
                principalColumn: "Id");
        }
    }
}
