using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SA.Domain.Entities.SA;

public partial class SagaContext : DbContext
{
    public SagaContext()
    {
    }

    public SagaContext(DbContextOptions<SagaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ActasGrado> ActasGrados { get; set; }

    public virtual DbSet<Actividade> Actividades { get; set; }

    public virtual DbSet<ActividadesCalendario> ActividadesCalendarios { get; set; }

    public virtual DbSet<AdicionesxGruposxAsignatura> AdicionesxGruposxAsignaturas { get; set; }

    public virtual DbSet<Admitido> Admitidos { get; set; }

    public virtual DbSet<Antiguedade> Antiguedades { get; set; }

    public virtual DbSet<AreasConocimientoXprograma> AreasConocimientoXprogramas { get; set; }

    public virtual DbSet<AreasNbc> AreasNbcs { get; set; }

    public virtual DbSet<AreasNucleo> AreasNucleos { get; set; }

    public virtual DbSet<AreasNucleosxPersona> AreasNucleosxPersonas { get; set; }

    public virtual DbSet<AreasNucleosxPrograma> AreasNucleosxProgramas { get; set; }

    public virtual DbSet<AsignaturasRelacionada> AsignaturasRelacionadas { get; set; }

    public virtual DbSet<AsignaturasRelacionale> AsignaturasRelacionales { get; set; }

    public virtual DbSet<AsignaturasxPlanesEstudio> AsignaturasxPlanesEstudios { get; set; }

    public virtual DbSet<AsignaturasxPlanesEstudioExcepcionesxInscripcione> AsignaturasxPlanesEstudioExcepcionesxInscripciones { get; set; }

    public virtual DbSet<AsignaturasxPrograma> AsignaturasxProgramas { get; set; }

    public virtual DbSet<AsignaturasxProgramasxDocente> AsignaturasxProgramasxDocentes { get; set; }

    public virtual DbSet<AsignaturasxProgramaxSubgrupo> AsignaturasxProgramaxSubgrupos { get; set; }

    public virtual DbSet<AuditoriaObjeto> AuditoriaObjetos { get; set; }

    public virtual DbSet<AuditoriaObjetosGrp> AuditoriaObjetosGrps { get; set; }

    public virtual DbSet<AuditoriaObjetosHn> AuditoriaObjetosHns { get; set; }

    public virtual DbSet<AuditoriaObjetosVario> AuditoriaObjetosVarios { get; set; }

    public virtual DbSet<Auditorium> Auditoria { get; set; }

    public virtual DbSet<AutoevaluacionToolValue> AutoevaluacionToolValues { get; set; }

    public virtual DbSet<AutoevaluacionToolValuesDetail> AutoevaluacionToolValuesDetails { get; set; }

    public virtual DbSet<AutoevaluacionToolValuexPrograma> AutoevaluacionToolValuexProgramas { get; set; }

    public virtual DbSet<Banco> Bancos { get; set; }

    public virtual DbSet<BancosxCuenta> BancosxCuentas { get; set; }

    public virtual DbSet<BarriosCrm> BarriosCrms { get; set; }

    public virtual DbSet<Calendario> Calendarios { get; set; }

    public virtual DbSet<CalificacionTooValuexPrograma> CalificacionTooValuexProgramas { get; set; }

    public virtual DbSet<CalificacionTool> CalificacionTools { get; set; }

    public virtual DbSet<CalificacionToolValue> CalificacionToolValues { get; set; }

    public virtual DbSet<CalificacionToolValuesDetail> CalificacionToolValuesDetails { get; set; }

    public virtual DbSet<CalificacionToolValuesxEgresado> CalificacionToolValuesxEgresados { get; set; }

    public virtual DbSet<CalificacionToolsxEntidadEducacion> CalificacionToolsxEntidadEducacions { get; set; }

    public virtual DbSet<CambiosProgramasJornada> CambiosProgramasJornadas { get; set; }

    public virtual DbSet<CamposxConfiguracion> CamposxConfiguracions { get; set; }

    public virtual DbSet<Capacidade> Capacidades { get; set; }

    public virtual DbSet<CaracterAcademico> CaracterAcademicos { get; set; }

    public virtual DbSet<CargaNombresTemporal> CargaNombresTemporals { get; set; }

    public virtual DbSet<CargosCrm> CargosCrms { get; set; }

    public virtual DbSet<CentrosCostosCrm> CentrosCostosCrms { get; set; }

    public virtual DbSet<CentrosCostosCrmxArticulo> CentrosCostosCrmxArticulos { get; set; }

    public virtual DbSet<CertificadosExpedido> CertificadosExpedidos { get; set; }

    public virtual DbSet<Configuracion> Configuracions { get; set; }

    public virtual DbSet<ConfiguracionCampo> ConfiguracionCampos { get; set; }

    public virtual DbSet<CreditosxNivel> CreditosxNivels { get; set; }

    public virtual DbSet<Criterio> Criterios { get; set; }

    public virtual DbSet<CriteriosCalificacion> CriteriosCalificacions { get; set; }

    public virtual DbSet<CubrimientoxPrograma> CubrimientoxProgramas { get; set; }

    public virtual DbSet<Dedicacion> Dedicacions { get; set; }

    public virtual DbSet<DepartamentosCrm> DepartamentosCrms { get; set; }

    public virtual DbSet<Deuda> Deudas { get; set; }

    public virtual DbSet<Dia> Dias { get; set; }

    public virtual DbSet<Discapacidade> Discapacidades { get; set; }

    public virtual DbSet<DisponibilidadDocente> DisponibilidadDocentes { get; set; }

    public virtual DbSet<DisponibilidadEntrevista> DisponibilidadEntrevistas { get; set; }

    public virtual DbSet<Docente> Docentes { get; set; }

    public virtual DbSet<DocentesxAsignatura> DocentesxAsignaturas { get; set; }

    public virtual DbSet<DocentesxUnidadOrganizacional> DocentesxUnidadOrganizacionals { get; set; }

    public virtual DbSet<Duracion> Duracions { get; set; }

    public virtual DbSet<EncabezadoResultado> EncabezadoResultados { get; set; }

    public virtual DbSet<Entidade> Entidades { get; set; }

    public virtual DbSet<EntidadesCreditoCrm> EntidadesCreditoCrms { get; set; }

    public virtual DbSet<Entrevista> Entrevistas { get; set; }

    public virtual DbSet<EntrevistasAsignada> EntrevistasAsignadas { get; set; }

    public virtual DbSet<EntrevistasxInscripcion> EntrevistasxInscripcions { get; set; }

    public virtual DbSet<EntrevistasxPrograma> EntrevistasxProgramas { get; set; }

    public virtual DbSet<EscalaResultado> EscalaResultados { get; set; }

    public virtual DbSet<EscalasResultado> EscalasResultados { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<EstadoAsignatura> EstadoAsignaturas { get; set; }

    public virtual DbSet<EstadosCivilesCrm> EstadosCivilesCrms { get; set; }

    public virtual DbSet<EstadosPrograma> EstadosProgramas { get; set; }

    public virtual DbSet<Etnia> Etnias { get; set; }

    public virtual DbSet<EvaluacionDocente> EvaluacionDocentes { get; set; }

    public virtual DbSet<EventLog> EventLogs { get; set; }

    public virtual DbSet<Familiare> Familiares { get; set; }

    public virtual DbSet<Fase> Fases { get; set; }

    public virtual DbSet<FormTool> FormTools { get; set; }

    public virtual DbSet<FormToolDetail> FormToolDetails { get; set; }

    public virtual DbSet<FormToolDetailsOption> FormToolDetailsOptions { get; set; }

    public virtual DbSet<FormToolValue> FormToolValues { get; set; }

    public virtual DbSet<FormToolValuesDetail> FormToolValuesDetails { get; set; }

    public virtual DbSet<GenerosCrm> GenerosCrms { get; set; }

    public virtual DbSet<Graduando> Graduandos { get; set; }

    public virtual DbSet<Grupo> Grupos { get; set; }

    public virtual DbSet<GrupoXasistencium> GrupoXasistencia { get; set; }

    public virtual DbSet<GruposPlane> GruposPlanes { get; set; }

    public virtual DbSet<GruposPlanesxArchivo> GruposPlanesxArchivos { get; set; }

    public virtual DbSet<HerramientasxGrupo> HerramientasxGrupos { get; set; }

    public virtual DbSet<HistorialEstadosInscripcione> HistorialEstadosInscripciones { get; set; }

    public virtual DbSet<HistorialInasistencium> HistorialInasistencia { get; set; }

    public virtual DbSet<HistoricoNota> HistoricoNotas { get; set; }

    public virtual DbSet<Homologacione> Homologaciones { get; set; }

    public virtual DbSet<HomologacionesDetalle> HomologacionesDetalles { get; set; }

    public virtual DbSet<HorariosxDisponibilidadDocente> HorariosxDisponibilidadDocentes { get; set; }

    public virtual DbSet<HorariosxGrupo> HorariosxGrupos { get; set; }

    public virtual DbSet<Ie> Ies { get; set; }

    public virtual DbSet<InformacionAcademica> InformacionAcademicas { get; set; }

    public virtual DbSet<InformacionAdicional> InformacionAdicionals { get; set; }

    public virtual DbSet<InformacionLaboral> InformacionLaborals { get; set; }

    public virtual DbSet<Inscripcione> Inscripciones { get; set; }

    public virtual DbSet<InscripcionesResumenAcademico> InscripcionesResumenAcademicos { get; set; }

    public virtual DbSet<InscripcionesxActasGrado> InscripcionesxActasGrados { get; set; }

    public virtual DbSet<InscripcionxProceso> InscripcionxProcesos { get; set; }

    public virtual DbSet<InscritosxGruposxAsignatura> InscritosxGruposxAsignaturas { get; set; }

    public virtual DbSet<InstitucionesAcademica> InstitucionesAcademicas { get; set; }

    public virtual DbSet<Justificacione> Justificaciones { get; set; }

    public virtual DbSet<LineasProfundizacion> LineasProfundizacions { get; set; }

    public virtual DbSet<Liquidacione> Liquidaciones { get; set; }

    public virtual DbSet<ListasTool> ListasTools { get; set; }

    public virtual DbSet<ListasToolDetail> ListasToolDetails { get; set; }

    public virtual DbSet<Matricula> Matriculas { get; set; }

    public virtual DbSet<MatriculasAcceso> MatriculasAccesos { get; set; }

    public virtual DbSet<MediosDifusionCrm> MediosDifusionCrms { get; set; }

    public virtual DbSet<Modalidade> Modalidades { get; set; }

    public virtual DbSet<ModalidadesCategoria> ModalidadesCategorias { get; set; }

    public virtual DbSet<MultimediaMatriculaContrato> MultimediaMatriculaContratos { get; set; }

    public virtual DbSet<Multimedium> Multimedia { get; set; }

    public virtual DbSet<MunicipiosCrm> MunicipiosCrms { get; set; }

    public virtual DbSet<Nbc> Nbcs { get; set; }

    public virtual DbSet<NivelesEducacion> NivelesEducacions { get; set; }

    public virtual DbSet<NivelesEstudio> NivelesEstudios { get; set; }

    public virtual DbSet<Nota> Notas { get; set; }

    public virtual DbSet<NotasPrueba> NotasPruebas { get; set; }

    public virtual DbSet<NovedadesNota> NovedadesNotas { get; set; }

    public virtual DbSet<NovedadesNotasDetalle> NovedadesNotasDetalles { get; set; }

    public virtual DbSet<OcupacionxDocente> OcupacionxDocentes { get; set; }

    public virtual DbSet<OcupacionxRecursoFisico> OcupacionxRecursoFisicos { get; set; }

    public virtual DbSet<Orden> Ordens { get; set; }

    public virtual DbSet<Origen> Origens { get; set; }

    public virtual DbSet<PaisFronteraCrm> PaisFronteraCrms { get; set; }

    public virtual DbSet<PaisesCrm> PaisesCrms { get; set; }

    public virtual DbSet<Parametro> Parametros { get; set; }

    public virtual DbSet<Pbcatcol> Pbcatcols { get; set; }

    public virtual DbSet<Pbcatedt> Pbcatedts { get; set; }

    public virtual DbSet<Pbcatfmt> Pbcatfmts { get; set; }

    public virtual DbSet<Pbcattbl> Pbcattbls { get; set; }

    public virtual DbSet<Pbcatvld> Pbcatvlds { get; set; }

    public virtual DbSet<Periodicidade> Periodicidades { get; set; }

    public virtual DbSet<Periodo> Periodos { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<PersonasCaracterizacion> PersonasCaracterizacions { get; set; }

    public virtual DbSet<PersonasCaracterizacionAdicional> PersonasCaracterizacionAdicionals { get; set; }

    public virtual DbSet<PersonasCrm> PersonasCrms { get; set; }

    public virtual DbSet<PersonasOtrosDato> PersonasOtrosDatos { get; set; }

    public virtual DbSet<PersonasxRequisitosxProceso> PersonasxRequisitosxProcesos { get; set; }

    public virtual DbSet<PersonasxTiposPersona> PersonasxTiposPersonas { get; set; }

    public virtual DbSet<PlanesAccion> PlanesAccions { get; set; }

    public virtual DbSet<PlanesDesarrollo> PlanesDesarrollos { get; set; }

    public virtual DbSet<PlanesDesarrolloItem> PlanesDesarrolloItems { get; set; }

    public virtual DbSet<PlanesDesarrolloJerarquia> PlanesDesarrolloJerarquias { get; set; }

    public virtual DbSet<PlanesEstudio> PlanesEstudios { get; set; }

    public virtual DbSet<PlanesEstudiosxInscripcion> PlanesEstudiosxInscripcions { get; set; }

    public virtual DbSet<Pregunta> Preguntas { get; set; }

    public virtual DbSet<PreguntasxEvaluacion> PreguntasxEvaluacions { get; set; }

    public virtual DbSet<Proceso> Procesos { get; set; }

    public virtual DbSet<Programa> Programas { get; set; }

    public virtual DbSet<ProgramacionEvaluacion> ProgramacionEvaluacions { get; set; }

    public virtual DbSet<ProgramasxProgramasCrm> ProgramasxProgramasCrms { get; set; }

    public virtual DbSet<ProgramasxTiposJornada> ProgramasxTiposJornadas { get; set; }

    public virtual DbSet<RangosHermano> RangosHermanos { get; set; }

    public virtual DbSet<RangosIngresosCrm> RangosIngresosCrms { get; set; }

    public virtual DbSet<Recaudo> Recaudos { get; set; }

    public virtual DbSet<RecaudosConfiguracione> RecaudosConfiguraciones { get; set; }

    public virtual DbSet<RecaudosConfiguracionesSeccione> RecaudosConfiguracionesSecciones { get; set; }

    public virtual DbSet<RecaudosConfiguracionesSeccionesDetalle> RecaudosConfiguracionesSeccionesDetalles { get; set; }

    public virtual DbSet<RecaudosConfiguracionesxEntidadesBancaria> RecaudosConfiguracionesxEntidadesBancarias { get; set; }

    public virtual DbSet<RecaudosDetalle> RecaudosDetalles { get; set; }

    public virtual DbSet<RecursosFisico> RecursosFisicos { get; set; }

    public virtual DbSet<Requisito> Requisitos { get; set; }

    public virtual DbSet<RequisitosxProceso> RequisitosxProcesos { get; set; }

    public virtual DbSet<ResponsablexEntrevistum> ResponsablexEntrevista { get; set; }

    public virtual DbSet<ResultadosEvaluacione> ResultadosEvaluaciones { get; set; }

    public virtual DbSet<SolicitudesCancelacion> SolicitudesCancelacions { get; set; }

    public virtual DbSet<SolicitudesCancelacionesDetalle> SolicitudesCancelacionesDetalles { get; set; }

    public virtual DbSet<Suficiencia> Suficiencias { get; set; }

    public virtual DbSet<SuficienciasxInscripcione> SuficienciasxInscripciones { get; set; }

    public virtual DbSet<TipoAcreditacion> TipoAcreditacions { get; set; }

    public virtual DbSet<TipoAsignatura> TipoAsignaturas { get; set; }

    public virtual DbSet<TipoCubrimiento> TipoCubrimientos { get; set; }

    public virtual DbSet<TipoEvaluacion> TipoEvaluacions { get; set; }

    public virtual DbSet<TipoIdentificacionCrm> TipoIdentificacionCrms { get; set; }

    public virtual DbSet<TipoNormaLegal> TipoNormaLegals { get; set; }

    public virtual DbSet<TipoOcupacion> TipoOcupacions { get; set; }

    public virtual DbSet<TipoOcupacionDocente> TipoOcupacionDocentes { get; set; }

    public virtual DbSet<TipoRecursoFisico> TipoRecursoFisicos { get; set; }

    public virtual DbSet<TipoReglamentoOpcional> TipoReglamentoOpcionals { get; set; }

    public virtual DbSet<TipoUnidadOrganizacional> TipoUnidadOrganizacionals { get; set; }

    public virtual DbSet<TiposCalificacionTool> TiposCalificacionTools { get; set; }

    public virtual DbSet<TiposCertificado> TiposCertificados { get; set; }

    public virtual DbSet<TiposDeuda> TiposDeudas { get; set; }

    public virtual DbSet<TiposEstado> TiposEstados { get; set; }

    public virtual DbSet<TiposGruposPlane> TiposGruposPlanes { get; set; }

    public virtual DbSet<TiposIngreso> TiposIngresos { get; set; }

    public virtual DbSet<TiposInscripcion> TiposInscripcions { get; set; }

    public virtual DbSet<TiposJornada> TiposJornadas { get; set; }

    public virtual DbSet<TiposLiquidacion> TiposLiquidacions { get; set; }

    public virtual DbSet<TiposPago> TiposPagos { get; set; }

    public virtual DbSet<TiposParentesco> TiposParentescos { get; set; }

    public virtual DbSet<TiposPersona> TiposPersonas { get; set; }

    public virtual DbSet<TiposRelacion> TiposRelacions { get; set; }

    public virtual DbSet<TiposTrabajo> TiposTrabajos { get; set; }

    public virtual DbSet<UnidadOrganizacional> UnidadOrganizacionals { get; set; }

    public virtual DbSet<VObjetosBd> VObjetosBds { get; set; }

    public virtual DbSet<ViewAsignaturasxPlanEstudio> ViewAsignaturasxPlanEstudios { get; set; }

    public virtual DbSet<ViewDocenteProgramacion> ViewDocenteProgramacions { get; set; }

    public virtual DbSet<ViewEntrevistum> ViewEntrevista { get; set; }

    public virtual DbSet<ViewEstudiantesProgramacionEvaluacion> ViewEstudiantesProgramacionEvaluacions { get; set; }

    public virtual DbSet<ViewJornadasByProgramaId> ViewJornadasByProgramaIds { get; set; }

    public virtual DbSet<ViewNotasAlumno> ViewNotasAlumnos { get; set; }

    public virtual DbSet<ViewPersona> ViewPersonas { get; set; }

    public virtual DbSet<ViewPersonasxTipoPersona> ViewPersonasxTipoPersonas { get; set; }

    public virtual DbSet<ViewProgramaByPersonaInscritum> ViewProgramaByPersonaInscrita { get; set; }

    public virtual DbSet<ViewProgramasByPersona> ViewProgramasByPersonas { get; set; }

    public virtual DbSet<ViewResponsablexEntrevistaxFecha> ViewResponsablexEntrevistaxFechas { get; set; }

    public virtual DbSet<ViewResponsablexEntrevistum> ViewResponsablexEntrevista { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DANI15;Database=saga;User Id=sa;Password=Medellin1.$;Encrypt=True;Trust Server Certificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Modern_Spanish_CI_AS");

        modelBuilder.Entity<ActasGrado>(entity =>
        {
            entity.HasKey(e => e.ActaGradoId);

            entity.ToTable("ActasGrado");

            entity.Property(e => e.Acta)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Libro)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Lugar)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TipoActa)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.AreaConocimiento).WithMany(p => p.ActasGrados)
                .HasForeignKey(d => d.AreaConocimientoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ActasGrado_AreasNBC");

            entity.HasOne(d => d.Decano).WithMany(p => p.ActasGradoDecanos)
                .HasForeignKey(d => d.DecanoId)
                .HasConstraintName("FK_ActasGrado_Personas");

            entity.HasOne(d => d.Rector).WithMany(p => p.ActasGradoRectors)
                .HasForeignKey(d => d.RectorId)
                .HasConstraintName("FK_ActasGrado_PersonasRector");

            entity.HasOne(d => d.SecretariaGeneral).WithMany(p => p.ActasGradoSecretariaGenerals)
                .HasForeignKey(d => d.SecretariaGeneralId)
                .HasConstraintName("FK_ActasGrado_ActasGradoSecr");
        });

        modelBuilder.Entity<Actividade>(entity =>
        {
            entity.HasKey(e => e.ActvidadId);

            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ActividadesCalendario>(entity =>
        {
            entity.ToTable("ActividadesCalendario");

            entity.HasIndex(e => new { e.ActividadId, e.CalendarioId }, "IT_ActividadesCalendario").IsUnique();

            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");

            entity.HasOne(d => d.Actividad).WithMany(p => p.ActividadesCalendarios)
                .HasForeignKey(d => d.ActividadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CalendariosXActividades_Actividades");

            entity.HasOne(d => d.Calendario).WithMany(p => p.ActividadesCalendarios)
                .HasForeignKey(d => d.CalendarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CalendariosXActividades_Calendarios");

            entity.HasOne(d => d.TipoUnidadOrganizacional).WithMany(p => p.ActividadesCalendarios)
                .HasForeignKey(d => d.TipoUnidadOrganizacionalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ActividadesCalendario_TipoUnidadOrganizacional");
        });

        modelBuilder.Entity<AdicionesxGruposxAsignatura>(entity =>
        {
            entity.HasKey(e => e.AdicionGrupoId);

            entity.ToTable("AdicionesxGruposxAsignatura");

            entity.Property(e => e.EstadoAdicionId).HasComment("1: Pendiente, 2: Aprobada, 3:Rechazada");
            entity.Property(e => e.FechaAprobacion).HasColumnType("datetime");
            entity.Property(e => e.FechaGeneracion).HasColumnType("datetime");

            entity.HasOne(d => d.AsignaturaRelacional).WithMany(p => p.AdicionesxGruposxAsignaturas)
                .HasForeignKey(d => d.AsignaturaRelacionalId)
                .HasConstraintName("FK_AdicionesxGruposxAsignatura_AsignaturasRelacionales");

            entity.HasOne(d => d.Grupo).WithMany(p => p.AdicionesxGruposxAsignaturas)
                .HasForeignKey(d => d.GrupoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdicionesxGruposxAsignatura_Grupos");

            entity.HasOne(d => d.Inscripcion).WithMany(p => p.AdicionesxGruposxAsignaturas)
                .HasForeignKey(d => d.InscripcionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdicionesxGruposxAsignatura_Inscripciones");

            entity.HasOne(d => d.Periodo).WithMany(p => p.AdicionesxGruposxAsignaturas)
                .HasForeignKey(d => d.PeriodoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdicionesxGruposxAsignatura_Periodo");
        });

        modelBuilder.Entity<Admitido>(entity =>
        {
            entity.HasKey(e => e.AdmitidosPeriodoId);

            entity.Property(e => e.Observaciones).IsUnicode(false);
            entity.Property(e => e.ResponsableAdmision)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Inscripcion).WithMany(p => p.Admitidos)
                .HasForeignKey(d => d.InscripcionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Admitidos_Inscripciones");

            entity.HasOne(d => d.Periodo).WithMany(p => p.Admitidos)
                .HasForeignKey(d => d.PeriodoId)
                .HasConstraintName("FK_Admitidos_Periodo");
        });

        modelBuilder.Entity<Antiguedade>(entity =>
        {
            entity.HasKey(e => e.AntiguedadId);

            entity.Property(e => e.CodigoAntiguedad).HasMaxLength(10);
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<AreasConocimientoXprograma>(entity =>
        {
            entity.HasKey(e => e.AreaConocimientXporgramaId);

            entity.ToTable("AreasConocimientoXProgramas");

            entity.Property(e => e.AreaConocimientXporgramaId).HasColumnName("AreaConocimientXPorgramaId");

            entity.HasOne(d => d.AreaConocimiento).WithMany(p => p.AreasConocimientoXprogramas)
                .HasForeignKey(d => d.AreaConocimientoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AreasConocimientoXProgramas_AreasConocimiento");

            entity.HasOne(d => d.Programa).WithMany(p => p.AreasConocimientoXprogramas)
                .HasForeignKey(d => d.ProgramaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AreasConocimientoXProgramas_Programas");
        });

        modelBuilder.Entity<AreasNbc>(entity =>
        {
            entity.HasKey(e => e.AreaConocimientoId).HasName("PK_AreasConocimiento");

            entity.ToTable("AreasNBC");

            entity.HasIndex(e => e.CodigoIes, "IX_AreasNBC").IsUnique();

            entity.Property(e => e.CodigoIes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nbcid).HasColumnName("NBCId");
        });

        modelBuilder.Entity<AreasNucleo>(entity =>
        {
            entity.HasKey(e => e.AreaNucleoId);

            entity.Property(e => e.NombreAreaNucleo).HasMaxLength(100);

            entity.HasOne(d => d.Programa).WithMany(p => p.AreasNucleos)
                .HasForeignKey(d => d.ProgramaId)
                .HasConstraintName("FK_AreasNucleos_Programas");
        });

        modelBuilder.Entity<AreasNucleosxPersona>(entity =>
        {
            entity.HasKey(e => e.AreaNucleoPersonaId);

            entity.Property(e => e.TipoRelacionAreaNucleo)
                .HasMaxLength(50)
                .HasComment("Coordinador\r\n\r\nDocenteAdscrito");

            entity.HasOne(d => d.AreaNucleo).WithMany(p => p.AreasNucleosxPersonas)
                .HasForeignKey(d => d.AreaNucleoId)
                .HasConstraintName("FK_AreasNucleosxPersonas_AreasNucleos");

            entity.HasOne(d => d.Persona).WithMany(p => p.AreasNucleosxPersonas)
                .HasForeignKey(d => d.PersonaId)
                .HasConstraintName("FK_AreasNucleosxPersonas_Personas");
        });

        modelBuilder.Entity<AreasNucleosxPrograma>(entity =>
        {
            entity.HasKey(e => e.AreaNucleoxProgramaId);

            entity.HasOne(d => d.AreaNucleo).WithMany(p => p.AreasNucleosxProgramas)
                .HasForeignKey(d => d.AreaNucleoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AreasNucleosxProgramas_AreasNucleos");

            entity.HasOne(d => d.Programa).WithMany(p => p.AreasNucleosxProgramas)
                .HasForeignKey(d => d.ProgramaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AreasNucleosxProgramas_Programas");
        });

        modelBuilder.Entity<AsignaturasRelacionada>(entity =>
        {
            entity.HasKey(e => e.AsignaturasRelacionadasId).HasName("PK_RequisitosAsignatura");

            entity.HasIndex(e => new { e.PlanEstudioAsignaturaId, e.AsignaturaIdRelacion, e.TiposRelacionId }, "IX_AsignaturasRelacionadas").IsUnique();

            entity.Property(e => e.TiposRelacionId).HasComment("Prerequisito =1 , correquisito=2");

            entity.HasOne(d => d.AsignaturaIdRelacionNavigation).WithMany(p => p.AsignaturasRelacionadaAsignaturaIdRelacionNavigations)
                .HasForeignKey(d => d.AsignaturaIdRelacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AsignaturasRelacionadas_AsignaturasxPlanesEstudios1");

            entity.HasOne(d => d.PlanEstudioAsignatura).WithMany(p => p.AsignaturasRelacionadaPlanEstudioAsignaturas)
                .HasForeignKey(d => d.PlanEstudioAsignaturaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AsignaturasRelacionadas_AsignaturasxPlanesEstudios");

            entity.HasOne(d => d.TiposRelacion).WithMany(p => p.AsignaturasRelacionada)
                .HasForeignKey(d => d.TiposRelacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AsignaturasRelacionadas_TiposRelacion");
        });

        modelBuilder.Entity<AsignaturasRelacionale>(entity =>
        {
            entity.HasKey(e => e.AsignaturaRelacionalId);

            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaUltimaModificacion).HasColumnType("datetime");

            entity.HasOne(d => d.PlanEstudioAsignaturaBase).WithMany(p => p.AsignaturasRelacionalePlanEstudioAsignaturaBases)
                .HasForeignKey(d => d.PlanEstudioAsignaturaBaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AsignaturasRelacionales_AsignaturasxPlanesEstudios");

            entity.HasOne(d => d.PlanEstudioAsignaturaRelacional).WithMany(p => p.AsignaturasRelacionalePlanEstudioAsignaturaRelacionals)
                .HasForeignKey(d => d.PlanEstudioAsignaturaRelacionalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AsignaturasRelacionales_AsignaturasxPlanesEstudios1");
        });

        modelBuilder.Entity<AsignaturasxPlanesEstudio>(entity =>
        {
            entity.HasKey(e => e.PlanEstudioAsignaturaId).HasName("PK_PlanesEstudiosXAsignaturas");

            entity.ToTable(tb => tb.HasTrigger("UpdateAsignaturasxPlanesEstudios"));

            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaIngreso).HasColumnType("datetime");
            entity.Property(e => e.Usuario)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.AsignaturasxPrograma).WithMany(p => p.AsignaturasxPlanesEstudios)
                .HasForeignKey(d => d.AsignaturasxProgramaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AsignaturasxPlanesEstudios_AsignaturasxProgramas");

            entity.HasOne(d => d.PlanEstudio).WithMany(p => p.AsignaturasxPlanesEstudios)
                .HasForeignKey(d => d.PlanEstudioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PlanesEstudiosXAsignaturas_PlanesEstudio1");

            entity.HasOne(d => d.TipoAsignatura).WithMany(p => p.AsignaturasxPlanesEstudios)
                .HasForeignKey(d => d.TipoAsignaturaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PlanesEstudiosXAsignaturas_TipoAsignatura");
        });

        modelBuilder.Entity<AsignaturasxPlanesEstudioExcepcionesxInscripcione>(entity =>
        {
            entity.HasKey(e => e.AsignaturaPlanEstudioxInscripcionId).HasName("PK_AsignaturasPlanesEstudiosxInscripciones");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Justificacion).HasMaxLength(300);
            entity.Property(e => e.Usuario).HasMaxLength(150);

            entity.HasOne(d => d.Inscripcion).WithMany(p => p.AsignaturasxPlanesEstudioExcepcionesxInscripciones)
                .HasForeignKey(d => d.InscripcionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AsignaturasPlanesEstudiosxInscripciones_Inscripciones");

            entity.HasOne(d => d.PlanEstudioAsignatura).WithMany(p => p.AsignaturasxPlanesEstudioExcepcionesxInscripciones)
                .HasForeignKey(d => d.PlanEstudioAsignaturaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AsignaturasPlanesEstudiosxInscripciones_AsignaturasxPlanesEstudios");
        });

        modelBuilder.Entity<AsignaturasxPrograma>(entity =>
        {
            entity.HasKey(e => e.AsignaturasxProgramaId).HasName("PK_Asignaturas");

            entity.HasIndex(e => e.CodigoIes, "CodigoAsignatura").IsUnique();

            entity.HasIndex(e => e.CodigoIes, "IX_AsignaturasxProgramas").IsUnique();

            entity.Property(e => e.AreaNbcid).HasColumnName("AreaNBCId");
            entity.Property(e => e.CodigoIes)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.NombreAsignatura)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.AreaNbc).WithMany(p => p.AsignaturasxProgramas)
                .HasForeignKey(d => d.AreaNbcid)
                .HasConstraintName("FK_AsignaturasxProgramas_AreasNBC");

            entity.HasOne(d => d.AsignaturasxProgramaSubgrupo).WithMany(p => p.AsignaturasxProgramas)
                .HasForeignKey(d => d.AsignaturasxProgramaSubgrupoId)
                .HasConstraintName("FK_AsignaturasxProgramas_AsignaturasxProgramaxSubgrupos");

            entity.HasOne(d => d.EstadoAsignatura).WithMany(p => p.AsignaturasxProgramas)
                .HasForeignKey(d => d.EstadoAsignaturaId)
                .HasConstraintName("FK_AsignaturasxProgramas_EstadoAsignatura");

            entity.HasOne(d => d.Programa).WithMany(p => p.AsignaturasxProgramas)
                .HasForeignKey(d => d.ProgramaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AsignaturasxProgramas_Programas");
        });

        modelBuilder.Entity<AsignaturasxProgramasxDocente>(entity =>
        {
            entity.HasKey(e => e.AsignaturasxProgramasxDocentesId);

            entity.HasIndex(e => new { e.AsignaturasxProgramaId, e.DocenteId }, "IX_AsignaturasxProgramasxDocentes").IsUnique();

            entity.HasOne(d => d.AsignaturasxPrograma).WithMany(p => p.AsignaturasxProgramasxDocentes)
                .HasForeignKey(d => d.AsignaturasxProgramaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AsignaturasxProgramasxDocentes_AsignaturasxProgramas");

            entity.HasOne(d => d.Docente).WithMany(p => p.AsignaturasxProgramasxDocentes)
                .HasForeignKey(d => d.DocenteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AsignaturasxProgramasxDocentes_Docentes");
        });

        modelBuilder.Entity<AsignaturasxProgramaxSubgrupo>(entity =>
        {
            entity.HasKey(e => e.AsignaturasxProgramaSubgrupoId).HasName("PK_AsignaturasxProgramaxGrupos");

            entity.Property(e => e.NombreAsignaturasxProgramaSubgrupo).HasMaxLength(50);

            entity.HasOne(d => d.Programa).WithMany(p => p.AsignaturasxProgramaxSubgrupos)
                .HasForeignKey(d => d.ProgramaId)
                .HasConstraintName("FK_AsignaturasxProgramaxGrupos_Programas");
        });

        modelBuilder.Entity<AuditoriaObjeto>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Evento)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Proceso)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AuditoriaObjetosGrp>(entity =>
        {
            entity.HasKey(e => e.AuditoriaObjetoId);

            entity.ToTable("AuditoriaObjetosGRP");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Evento)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Proceso)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AuditoriaObjetosHn>(entity =>
        {
            entity.HasKey(e => e.AuditoriaObjetoId);

            entity.ToTable("AuditoriaObjetosHN");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Evento)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Proceso)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AuditoriaObjetosVario>(entity =>
        {
            entity.HasKey(e => e.AuditoriaObjetoId);

            entity.Property(e => e.Descripcion)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Evento)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Proceso)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Auditorium>(entity =>
        {
            entity.HasKey(e => e.AuditoriaId);

            entity.ToTable(tb => tb.HasTrigger("DeleteAuditoria"));

            entity.Property(e => e.Descripcion)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Evento)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Proceso).IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AutoevaluacionToolValue>(entity =>
        {
            entity.HasKey(e => e.AutoevaluacionToolValuesId);

            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.Observaciones).HasMaxLength(300);
            entity.Property(e => e.UserCreated).HasMaxLength(200);
            entity.Property(e => e.Usuario).HasMaxLength(200);

            entity.HasOne(d => d.CalificacionTool).WithMany(p => p.AutoevaluacionToolValues)
                .HasForeignKey(d => d.CalificacionToolId)
                .HasConstraintName("FK_AutoevaluacionToolValues_CalificacionTools");

            entity.HasOne(d => d.Grupo).WithMany(p => p.AutoevaluacionToolValues)
                .HasForeignKey(d => d.GrupoId)
                .HasConstraintName("FK_AutoevaluacionToolValues_Grupos");

            entity.HasOne(d => d.Periodo).WithMany(p => p.AutoevaluacionToolValues)
                .HasForeignKey(d => d.PeriodoId)
                .HasConstraintName("FK_AutoevaluacionToolValues_Periodo");
        });

        modelBuilder.Entity<AutoevaluacionToolValuesDetail>(entity =>
        {
            entity.HasKey(e => e.AutoevaluacionToolValuesDetailsId);

            entity.HasOne(d => d.AutoevaluacionToolValues).WithMany(p => p.AutoevaluacionToolValuesDetails)
                .HasForeignKey(d => d.AutoevaluacionToolValuesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AutoevaluacionToolValuesDetails_AutoevaluacionToolValues");

            entity.HasOne(d => d.Escala).WithMany(p => p.AutoevaluacionToolValuesDetails)
                .HasForeignKey(d => d.EscalaId)
                .HasConstraintName("FK_AutoevaluacionToolValuesDetails_EscalasResultados");

            entity.HasOne(d => d.Fase).WithMany(p => p.AutoevaluacionToolValuesDetails)
                .HasForeignKey(d => d.FaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AutoevaluacionToolValuesDetails_Fases");

            entity.HasOne(d => d.Pregunta).WithMany(p => p.AutoevaluacionToolValuesDetails)
                .HasForeignKey(d => d.PreguntaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AutoevaluacionToolValuesDetails_Preguntas");
        });

        modelBuilder.Entity<AutoevaluacionToolValuexPrograma>(entity =>
        {
            entity.HasKey(e => e.AutoevaluacionToolValueProgramaId);

            entity.ToTable("AutoevaluacionToolValuexPrograma");

            entity.HasOne(d => d.AutoevaluacionToolValue).WithMany(p => p.AutoevaluacionToolValuexProgramas)
                .HasForeignKey(d => d.AutoevaluacionToolValueId)
                .HasConstraintName("FK_AutoevaluacionToolValuexPrograma_AutoevaluacionToolValues");

            entity.HasOne(d => d.Programa).WithMany(p => p.AutoevaluacionToolValuexProgramas)
                .HasForeignKey(d => d.ProgramaId)
                .HasConstraintName("FK_AutoevaluacionToolValuexPrograma_Programas");
        });

        modelBuilder.Entity<Banco>(entity =>
        {
            entity.Property(e => e.CodigoBanco).HasMaxLength(20);
            entity.Property(e => e.NombreBanco).HasMaxLength(80);
        });

        modelBuilder.Entity<BancosxCuenta>(entity =>
        {
            entity.HasKey(e => e.BancoxCuentaId);

            entity.Property(e => e.CuentaNumero)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionCuenta)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Iesid).HasColumnName("IESId");
            entity.Property(e => e.KaNiCuentaBanco)
                .HasComment("Clave primaria de las cuentas contables del sistema SAG Financiero para saber a que cuenta deben entrar los pagos")
                .HasColumnName("ka_ni_cuenta_banco");
            entity.Property(e => e.PasarelaPaymentMethod)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Banco).WithMany(p => p.BancosxCuenta)
                .HasForeignKey(d => d.BancoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BancosxCuentas_Bancos");
        });

        modelBuilder.Entity<BarriosCrm>(entity =>
        {
            entity.HasKey(e => e.BarrioId);

            entity.ToTable("Barrios_CRM");

            entity.HasIndex(e => e.CodigoBarrio, "IX_Barrios_Codigo_CRM");

            entity.Property(e => e.CodigoBarrio).HasMaxLength(50);
            entity.Property(e => e.CodigoDpta).HasMaxLength(50);
            entity.Property(e => e.CodigoMpio).HasMaxLength(50);
            entity.Property(e => e.CodigoPais).HasMaxLength(50);
            entity.Property(e => e.DescripcionBarrio).HasMaxLength(100);
            entity.Property(e => e.DescripcionDpta).HasMaxLength(100);
            entity.Property(e => e.DescripcionMpio).HasMaxLength(100);
            entity.Property(e => e.DescripcionPais).HasMaxLength(100);

            entity.HasOne(d => d.Municipio).WithMany(p => p.BarriosCrms)
                .HasForeignKey(d => d.MunicipioId)
                .HasConstraintName("FK_Barrios_CRM_Municipios_CRM");
        });

        modelBuilder.Entity<Calendario>(entity =>
        {
            entity.HasIndex(e => new { e.NombreCalendario, e.TipoCalendario, e.PeriodoAcademico }, "IX_NombreCalendarioTipoCalPeriodo").IsUnique();

            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.NombreCalendario).HasMaxLength(100);
            entity.Property(e => e.PeriodoAcademico).HasMaxLength(20);
            entity.Property(e => e.TipoCalendario).HasMaxLength(50);

            entity.HasOne(d => d.Periodo).WithMany(p => p.Calendarios)
                .HasForeignKey(d => d.PeriodoId)
                .HasConstraintName("FK_CalendariosPeriodos");
        });

        modelBuilder.Entity<CalificacionTooValuexPrograma>(entity =>
        {
            entity.HasKey(e => e.CalificacionTooValuesProgramaId);

            entity.ToTable("CalificacionTooValuexPrograma");

            entity.HasOne(d => d.CalificacionTooValues).WithMany(p => p.CalificacionTooValuexProgramas)
                .HasForeignKey(d => d.CalificacionTooValuesId)
                .HasConstraintName("FK_CalificacionTooValuexPrograma_CalificacionToolValues");

            entity.HasOne(d => d.Programa).WithMany(p => p.CalificacionTooValuexProgramas)
                .HasForeignKey(d => d.ProgramaId)
                .HasConstraintName("FK_CalificacionTooValuexPrograma_Programas");
        });

        modelBuilder.Entity<CalificacionTool>(entity =>
        {
            entity.HasKey(e => e.CalificacionToolId).HasName("PK_CalificacionTool");

            entity.Property(e => e.Descripcion).HasMaxLength(500);
            entity.Property(e => e.EscalaExplicacion).HasMaxLength(500);
            entity.Property(e => e.Estado).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(200);
            entity.Property(e => e.Titulo).HasMaxLength(200);

            entity.HasOne(d => d.EntidadEducacion).WithMany(p => p.CalificacionTools)
                .HasForeignKey(d => d.EntidadEducacionId)
                .HasConstraintName("FK_CalificacionTools_IES");

            entity.HasOne(d => d.TipoCalificacionTool).WithMany(p => p.CalificacionTools)
                .HasForeignKey(d => d.TipoCalificacionToolId)
                .HasConstraintName("FK_CalificacionTools_TiposCalificacionTools");
        });

        modelBuilder.Entity<CalificacionToolValue>(entity =>
        {
            entity.HasKey(e => e.CalificacionToolValuesId);

            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(800)
                .IsUnicode(false)
                .HasComment("");
            entity.Property(e => e.UserCreated).HasMaxLength(200);
            entity.Property(e => e.Usuario).HasMaxLength(200);

            entity.HasOne(d => d.AreaNucleo).WithMany(p => p.CalificacionToolValues)
                .HasForeignKey(d => d.AreaNucleoId)
                .HasConstraintName("FK_CalificacionToolValues_AreasNucleos");

            entity.HasOne(d => d.CalificacionTool).WithMany(p => p.CalificacionToolValues)
                .HasForeignKey(d => d.CalificacionToolId)
                .HasConstraintName("FK_CalificacionToolValues_CalificacionTools");

            entity.HasOne(d => d.EntidadEducacion).WithMany(p => p.CalificacionToolValues)
                .HasForeignKey(d => d.EntidadEducacionId)
                .HasConstraintName("FK_CalificacionToolValues_IES");

            entity.HasOne(d => d.Grupo).WithMany(p => p.CalificacionToolValues)
                .HasForeignKey(d => d.GrupoId)
                .HasConstraintName("FK_CalificacionToolValues_Grupos");

            entity.HasOne(d => d.Periodo).WithMany(p => p.CalificacionToolValues)
                .HasForeignKey(d => d.PeriodoId)
                .HasConstraintName("FK_CalificacionToolValues_Periodo");
        });

        modelBuilder.Entity<CalificacionToolValuesDetail>(entity =>
        {
            entity.HasKey(e => e.CalificacionToolValuesDetailsId);

            entity.Property(e => e.Resultado)
                .HasMaxLength(800)
                .IsUnicode(false);

            entity.HasOne(d => d.CalificacionToolValues).WithMany(p => p.CalificacionToolValuesDetails)
                .HasForeignKey(d => d.CalificacionToolValuesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CalificacionToolValuesDetails_CalificacionToolValues");

            entity.HasOne(d => d.Escala).WithMany(p => p.CalificacionToolValuesDetails)
                .HasForeignKey(d => d.EscalaId)
                .HasConstraintName("FK_CalificacionToolValuesDetails_EscalasResultados");

            entity.HasOne(d => d.Fase).WithMany(p => p.CalificacionToolValuesDetails)
                .HasForeignKey(d => d.FaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CalificacionToolValuesDetails_Fases");

            entity.HasOne(d => d.Pregunta).WithMany(p => p.CalificacionToolValuesDetails)
                .HasForeignKey(d => d.PreguntaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CalificacionToolValuesDetails_Preguntas");
        });

        modelBuilder.Entity<CalificacionToolValuesxEgresado>(entity =>
        {
            entity.Property(e => e.ActividadEmpresarial).HasMaxLength(200);
            entity.Property(e => e.Cargo).HasMaxLength(200);
            entity.Property(e => e.EntidadDondeLabora).HasMaxLength(200);
            entity.Property(e => e.PosgradoDonde).HasMaxLength(200);
            entity.Property(e => e.SituacionLaboral).HasMaxLength(50);
            entity.Property(e => e.TipoEmpresa).HasMaxLength(50);

            entity.HasOne(d => d.CalificacionToolValue).WithMany(p => p.CalificacionToolValuesxEgresados)
                .HasForeignKey(d => d.CalificacionToolValueId)
                .HasConstraintName("FK_CalificacionToolValuesxEgresados_CalificacionToolValues");
        });

        modelBuilder.Entity<CalificacionToolsxEntidadEducacion>(entity =>
        {
            entity.ToTable("CalificacionToolsxEntidadEducacion");

            entity.HasOne(d => d.CalificacionTool).WithMany(p => p.CalificacionToolsxEntidadEducacions)
                .HasForeignKey(d => d.CalificacionToolId)
                .HasConstraintName("FK_CalificacionToolsxEntidadEducacion_CalificacionTools");

            entity.HasOne(d => d.EntidadEducacion).WithMany(p => p.CalificacionToolsxEntidadEducacions)
                .HasForeignKey(d => d.EntidadEducacionId)
                .HasConstraintName("FK_CalificacionToolsxEntidadEducacion_IES");
        });

        modelBuilder.Entity<CambiosProgramasJornada>(entity =>
        {
            entity.HasKey(e => e.CambioEntidadId);

            entity.Property(e => e.FechaAprobacion).HasColumnType("datetime");

            entity.HasOne(d => d.Estado).WithMany(p => p.CambiosProgramasJornada)
                .HasForeignKey(d => d.EstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CambiosProgramasJornadas_Estados");

            entity.HasOne(d => d.Inscripcion).WithMany(p => p.CambiosProgramasJornada)
                .HasForeignKey(d => d.InscripcionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CambiosProgramasJornadas_Inscripciones");

            entity.HasOne(d => d.JornadaActual).WithMany(p => p.CambiosProgramasJornadaJornadaActuals)
                .HasForeignKey(d => d.JornadaActualId)
                .HasConstraintName("FK_CambiosProgramasJornadas_TiposJornadas");

            entity.HasOne(d => d.JornadaCambio).WithMany(p => p.CambiosProgramasJornadaJornadaCambios)
                .HasForeignKey(d => d.JornadaCambioId)
                .HasConstraintName("FK_CambiosProgramasJornadas_TiposJornadas1");

            entity.HasOne(d => d.Periodo).WithMany(p => p.CambiosProgramasJornada)
                .HasForeignKey(d => d.PeriodoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CambiosProgramasJornadas_Periodo");

            entity.HasOne(d => d.ProgramaActual).WithMany(p => p.CambiosProgramasJornadaProgramaActuals)
                .HasForeignKey(d => d.ProgramaActualId)
                .HasConstraintName("FK_CambiosProgramasJornadas_Programas");

            entity.HasOne(d => d.ProgramaCambio).WithMany(p => p.CambiosProgramasJornadaProgramaCambios)
                .HasForeignKey(d => d.ProgramaCambioId)
                .HasConstraintName("FK_CambiosProgramasJornadas_Programas1");
        });

        modelBuilder.Entity<CamposxConfiguracion>(entity =>
        {
            entity.HasKey(e => e.CampoxConfiguracionId);

            entity.ToTable("CamposxConfiguracion");

            entity.HasOne(d => d.Campo).WithMany(p => p.CamposxConfiguracions)
                .HasForeignKey(d => d.CampoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CamposxConfiguracion_FormToolDetails");

            entity.HasOne(d => d.ConfiguracionCampos).WithMany(p => p.CamposxConfiguracions)
                .HasForeignKey(d => d.ConfiguracionCamposId)
                .HasConstraintName("FK_CamposxConfiguracion_ConfiguracionCampos");
        });

        modelBuilder.Entity<Capacidade>(entity =>
        {
            entity.HasKey(e => e.CapacidadId);

            entity.HasIndex(e => e.CodigoIes, "IX_Capacidades").IsUnique();

            entity.Property(e => e.CodigoIes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CaracterAcademico>(entity =>
        {
            entity.ToTable("CaracterAcademico");

            entity.HasIndex(e => e.CodigoIes, "IX_CaracterAcademico").IsUnique();

            entity.Property(e => e.CodigoIes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CargaNombresTemporal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CargaNombresTemporal");

            entity.Property(e => e.Identificacion).HasColumnType("decimal(16, 0)");
            entity.Property(e => e.PrimerApellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrimerNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SegundoApellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SegundoNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CargosCrm>(entity =>
        {
            entity.HasKey(e => e.CargoId).HasName("PK_Cargos_1");

            entity.ToTable("Cargos_CRM");

            entity.Property(e => e.CargoIes)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CargoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CentrosCostosCrm>(entity =>
        {
            entity.HasKey(e => e.CentroCostoId);

            entity.ToTable("CentrosCostos_CRM");

            entity.Property(e => e.CodigoArticuloExtemporaneoDosPrimerSemestre).HasMaxLength(10);
            entity.Property(e => e.CodigoArticuloExtemporaneoDosSegundoSemestre).HasMaxLength(10);
            entity.Property(e => e.CodigoArticuloExtemporaneoPrimerSemestre).HasMaxLength(10);
            entity.Property(e => e.CodigoArticuloExtemporaneoSegundoSemestre).HasMaxLength(10);
            entity.Property(e => e.CodigoArticuloPrimerSemestre).HasMaxLength(10);
            entity.Property(e => e.CodigoArticuloProntoPagoDosPrimerSemestre)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoArticuloProntoPagoDosSegundoSemestre)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoArticuloProntoPagoPrimerSemestre)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoArticuloProntoPagoSegundoSemestre)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoArticuloProntoPagoUnoPrimerSemestre)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoArticuloProntoPagoUnoSegundoSemestre)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoArticuloSegundoSemestre).HasMaxLength(10);
            entity.Property(e => e.CodigoArticuloSeguroPrimerSemestre).HasMaxLength(10);
            entity.Property(e => e.CodigoArticuloSeguroSegundoSemestre).HasMaxLength(10);
            entity.Property(e => e.CodigoCentroCostos).HasMaxLength(50);
            entity.Property(e => e.KaNiCuentaBanco)
                .HasMaxLength(50)
                .HasColumnName("ka_ni_cuenta_banco");
            entity.Property(e => e.NombreCentroCostos).HasMaxLength(250);
            entity.Property(e => e.Valor).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ValorSeguro).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.EntidadEducacion).WithMany(p => p.CentrosCostosCrms)
                .HasForeignKey(d => d.EntidadEducacionId)
                .HasConstraintName("FK_CentrosCostos_CRM_IES");

            entity.HasOne(d => d.Programa).WithMany(p => p.CentrosCostosCrms)
                .HasForeignKey(d => d.ProgramaId)
                .HasConstraintName("FK_CentrosCostos_CRM_Programas");
        });

        modelBuilder.Entity<CentrosCostosCrmxArticulo>(entity =>
        {
            entity.HasKey(e => e.CentroCostoCrmxArticuloId);

            entity.ToTable("CentrosCostos_CRMxArticulos");

            entity.Property(e => e.CentroCostoCrmxArticuloId).HasColumnName("CentroCosto_CRMxArticuloId");
            entity.Property(e => e.Articulo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BecaCategoria)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DetalleArticulo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("Es como se quiere que quede la descripción de la factura. Ej: DERECHOS DE MATRICULA SEMESTRE N° 1 - CLIENTES");
            entity.Property(e => e.Tipo)
                .HasMaxLength(100)
                .HasComment("La forma en como se hace el cobro es por creditos o matricula completa");

            entity.HasOne(d => d.CentroCosto).WithMany(p => p.CentrosCostosCrmxArticulos)
                .HasForeignKey(d => d.CentroCostoId)
                .HasConstraintName("FK_CentrosCostos_CRMxArticulos_CentrosCostos_CRM");
        });

        modelBuilder.Entity<CertificadosExpedido>(entity =>
        {
            entity.HasKey(e => e.CertificadoExpedidoId);

            entity.Property(e => e.FechaExpedicion).HasColumnType("datetime");
            entity.Property(e => e.NumeroRadicado)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Inscripcion).WithMany(p => p.CertificadosExpedidos)
                .HasForeignKey(d => d.InscripcionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CertificadosExpedidos_Inscripciones");

            entity.HasOne(d => d.TipoCertificado).WithMany(p => p.CertificadosExpedidos)
                .HasForeignKey(d => d.TipoCertificadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CertificadosExpedidos_TiposCertificados");
        });

        modelBuilder.Entity<Configuracion>(entity =>
        {
            entity.ToTable("Configuracion");

            entity.Property(e => e.InscripcionConsultor).HasDefaultValue(0, "DF_Configuracion_InscripcionConsultor");
            entity.Property(e => e.InscripcionCoordinador).HasDefaultValue(0, "DF_Configuracion_InscripcionCoordinador");
            entity.Property(e => e.InscripcionDocente).HasDefaultValue(0, "DF_Configuracion_InscripcionDocente");
        });

        modelBuilder.Entity<ConfiguracionCampo>(entity =>
        {
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CreditosxNivel>(entity =>
        {
            entity.ToTable("CreditosxNivel");

            entity.Property(e => e.CreditosxNivel1).HasColumnName("CreditosxNivel");

            entity.HasOne(d => d.PlanEstudio).WithMany(p => p.CreditosxNivels)
                .HasForeignKey(d => d.PlanEstudioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CreditosxNivel_PlanesEstudio");
        });

        modelBuilder.Entity<Criterio>(entity =>
        {
            entity.Property(e => e.Descripcion).HasMaxLength(200);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Peso).HasColumnType("numeric(5, 2)");

            entity.HasOne(d => d.CalificacionTool).WithMany(p => p.Criterios)
                .HasForeignKey(d => d.CalificacionToolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Criterios_CalificacionTools");
        });

        modelBuilder.Entity<CriteriosCalificacion>(entity =>
        {
            entity.HasKey(e => e.CriterioCalificacionId);

            entity.ToTable("CriteriosCalificacion");

            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Tipo).HasMaxLength(50);
            entity.Property(e => e.ValorMaximo).HasColumnType("decimal(3, 2)");

            entity.HasOne(d => d.CalificacionTool).WithMany(p => p.CriteriosCalificacions)
                .HasForeignKey(d => d.CalificacionToolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CriteriosCalificacion_CalificacionTools");

            entity.HasOne(d => d.Criterio).WithMany(p => p.CriteriosCalificacions)
                .HasForeignKey(d => d.CriterioId)
                .HasConstraintName("FK_CriteriosCalificacion_Criterios");
        });

        modelBuilder.Entity<CubrimientoxPrograma>(entity =>
        {
            entity.HasKey(e => e.CubrimientoId).HasName("PK_Cubrimiento_Programa");

            entity.ToTable("CubrimientoxPrograma");

            entity.Property(e => e.Metodologia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("01-Presencial o a 02-distancia");

            entity.HasOne(d => d.Programa).WithMany(p => p.CubrimientoxProgramas)
                .HasForeignKey(d => d.ProgramaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CubrimientoxPrograma_Programas");

            entity.HasOne(d => d.TipoCubrimiento).WithMany(p => p.CubrimientoxProgramas)
                .HasForeignKey(d => d.TipoCubrimientoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CubrimientoxPrograma_TipoCubrimiento");
        });

        modelBuilder.Entity<Dedicacion>(entity =>
        {
            entity.ToTable("Dedicacion");

            entity.Property(e => e.CodigoIes)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DepartamentosCrm>(entity =>
        {
            entity.HasKey(e => e.DepartamentoId).HasName("PK_Departamentos");

            entity.ToTable("Departamentos_CRM");

            entity.HasIndex(e => e.Codigo, "IX_Departamentos_Codigo_CRM");

            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.CodigoPais).HasMaxLength(50);
            entity.Property(e => e.CodigoSnies)
                .HasMaxLength(50)
                .HasColumnName("CodigoSNIES");
            entity.Property(e => e.DescripcionPais).HasMaxLength(150);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Pais).WithMany(p => p.DepartamentosCrms)
                .HasForeignKey(d => d.PaisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Departamentos_CRM_Paises_CRM");
        });

        modelBuilder.Entity<Deuda>(entity =>
        {
            entity.Property(e => e.Articulo).HasMaxLength(200);
            entity.Property(e => e.CodigoArticulo).HasMaxLength(200);
            entity.Property(e => e.CodigoCcostos)
                .HasMaxLength(200)
                .HasColumnName("CodigoCCostos");
            entity.Property(e => e.Descripcion).HasMaxLength(300);
            entity.Property(e => e.Documento).HasMaxLength(200);
            entity.Property(e => e.FechaDeuda).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.FechaPago).HasColumnType("datetime");
            entity.Property(e => e.Iesid).HasColumnName("IESId");
            entity.Property(e => e.NombreCcostos)
                .HasMaxLength(200)
                .HasColumnName("NombreCCostos");
            entity.Property(e => e.ObservacionPago).HasMaxLength(200);
            entity.Property(e => e.SEstado)
                .HasMaxLength(10)
                .HasColumnName("s_estado");
            entity.Property(e => e.SFuente)
                .HasMaxLength(50)
                .HasColumnName("s_fuente");
            entity.Property(e => e.SIdentificador)
                .HasMaxLength(50)
                .HasColumnName("s_identificador");
            entity.Property(e => e.SMensaje)
                .HasMaxLength(800)
                .HasColumnName("s_mensaje");
            entity.Property(e => e.SNumDocumento)
                .HasMaxLength(50)
                .HasColumnName("s_num_documento");
            entity.Property(e => e.Saldo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usuario).HasMaxLength(300);
            entity.Property(e => e.Valor).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.EstadoDeuda).WithMany(p => p.Deuda)
                .HasForeignKey(d => d.EstadoDeudaId)
                .HasConstraintName("FK_Deudas_Estados");

            entity.HasOne(d => d.Ies).WithMany(p => p.Deuda)
                .HasForeignKey(d => d.Iesid)
                .HasConstraintName("FK_Deudas_IES");

            entity.HasOne(d => d.Inscripcion).WithMany(p => p.Deuda)
                .HasForeignKey(d => d.InscripcionId)
                .HasConstraintName("FK_Deudas_Inscripciones");

            entity.HasOne(d => d.Periodo).WithMany(p => p.Deuda)
                .HasForeignKey(d => d.PeriodoId)
                .HasConstraintName("FK_Deudas_Periodo");

            entity.HasOne(d => d.Persona).WithMany(p => p.Deuda)
                .HasForeignKey(d => d.PersonaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Deudas_Personas");

            entity.HasOne(d => d.TipoDeuda).WithMany(p => p.Deuda)
                .HasForeignKey(d => d.TipoDeudaId)
                .HasConstraintName("FK_Deudas_TiposDeudas");
        });

        modelBuilder.Entity<Dia>(entity =>
        {
            entity.Property(e => e.Nombre).HasMaxLength(20);
        });

        modelBuilder.Entity<Discapacidade>(entity =>
        {
            entity.HasKey(e => e.DiscapacidadId);

            entity.HasIndex(e => e.CodigoIes, "IX_Discapacidades").IsUnique();

            entity.Property(e => e.CodigoIes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DisponibilidadDocente>(entity =>
        {
            entity.HasKey(e => e.DisponibilidadDocenteId).HasName("PK_Dedicaciones");

            entity.HasOne(d => d.Docente).WithMany(p => p.DisponibilidadDocentes)
                .HasForeignKey(d => d.DocenteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DisponibilidadDocentes_Docentes");

            entity.HasOne(d => d.Estado).WithMany(p => p.DisponibilidadDocentes)
                .HasForeignKey(d => d.EstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DisponibilidadDocentes_Estados");
        });

        modelBuilder.Entity<DisponibilidadEntrevista>(entity =>
        {
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Horario).HasColumnType("datetime");
            entity.Property(e => e.Periodo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Docente>(entity =>
        {
            entity.HasOne(d => d.Persona).WithMany(p => p.Docentes)
                .HasForeignKey(d => d.PersonaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Docentes_Personas");

            entity.HasOne(d => d.TipoDocente).WithMany(p => p.Docentes)
                .HasForeignKey(d => d.TipoDocenteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Docentes_Dedicacion");
        });

        modelBuilder.Entity<DocentesxAsignatura>(entity =>
        {
            entity.HasKey(e => e.DocentesAsignaturaId);

            entity.ToTable("DocentesxAsignatura");

            entity.HasIndex(e => e.DocenteId, "NonClusteredIndex-20200414-DOCA");

            entity.HasOne(d => d.Asignatura).WithMany(p => p.DocentesxAsignaturas)
                .HasForeignKey(d => d.AsignaturaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DocentesxAsignatura_AsignaturasxProgramas");

            entity.HasOne(d => d.Docente).WithMany(p => p.DocentesxAsignaturas)
                .HasForeignKey(d => d.DocenteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DocentesxAsignatura_Docentes");

            entity.HasOne(d => d.Periodo).WithMany(p => p.DocentesxAsignaturas)
                .HasForeignKey(d => d.PeriodoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DocentesxAsignatura_Periodo");
        });

        modelBuilder.Entity<DocentesxUnidadOrganizacional>(entity =>
        {
            entity.HasKey(e => e.DocenteUnidadOrganizacionalId);

            entity.ToTable("DocentesxUnidadOrganizacional");

            entity.Property(e => e.FechaIngresoUo)
                .HasColumnType("datetime")
                .HasColumnName("FechaIngresoUO");

            entity.HasOne(d => d.Docente).WithMany(p => p.DocentesxUnidadOrganizacionals)
                .HasForeignKey(d => d.DocenteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DocentesxUnidadOrganizacional_Docentes");

            entity.HasOne(d => d.UnidadOrganizacional).WithMany(p => p.DocentesxUnidadOrganizacionals)
                .HasForeignKey(d => d.UnidadOrganizacionalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DocentesxUnidadOrganizacional_UnidadOrganizacional");
        });

        modelBuilder.Entity<Duracion>(entity =>
        {
            entity.ToTable("Duracion");

            entity.HasIndex(e => e.CodigoIes, "IX_Duracion").IsUnique();

            entity.Property(e => e.DuracionId).ValueGeneratedNever();
            entity.Property(e => e.CodigoIes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EncabezadoResultado>(entity =>
        {
            entity.HasKey(e => e.EncabezadoResultadosId).HasName("PK_ResultadosEvaluacion");

            entity.Property(e => e.FechaEvaluacion).HasColumnType("datetime");

            entity.HasOne(d => d.EvaluacionDocente).WithMany(p => p.EncabezadoResultados)
                .HasForeignKey(d => d.EvaluacionDocenteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EncabezadoResultados_EvaluacionDocente");
        });

        modelBuilder.Entity<Entidade>(entity =>
        {
            entity.HasKey(e => e.EntidadId);

            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.NombreEntidad).HasMaxLength(150);
            entity.Property(e => e.TipoEntidad).HasMaxLength(50);
        });

        modelBuilder.Entity<EntidadesCreditoCrm>(entity =>
        {
            entity.HasKey(e => e.EntidadCreditoId);

            entity.ToTable("EntidadesCredito_CRM");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Entrevista>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("Almacena la información de las entrevistas, tanto disponibles como asignadas"));

            entity.Property(e => e.EstadoId).HasComment("Contiene el estado de la entrevista: disponible, asignada, reprogramada, no asistida, cancelada");
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");

            entity.HasOne(d => d.OcupacionRecursoFisico).WithMany(p => p.Entrevista)
                .HasForeignKey(d => d.OcupacionRecursoFisicoId)
                .HasConstraintName("FK_Entrevistas_OcupacionxRecursoFisico");

            entity.HasOne(d => d.Periodo).WithMany(p => p.Entrevista)
                .HasForeignKey(d => d.PeriodoId)
                .HasConstraintName("FK_Entrevistas_Periodo");

            entity.HasOne(d => d.Programa).WithMany(p => p.Entrevista)
                .HasForeignKey(d => d.ProgramaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Entrevistas_Programas");

            entity.HasOne(d => d.RecursoFisico).WithMany(p => p.Entrevista)
                .HasForeignKey(d => d.RecursoFisicoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Entrevistas_RecursosFisicos");
        });

        modelBuilder.Entity<EntrevistasAsignada>(entity =>
        {
            entity.HasKey(e => e.EntrevistaAsignadaId);

            entity.Property(e => e.Periodo)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.DisponibilidadEntrevista).WithMany(p => p.EntrevistasAsignada)
                .HasForeignKey(d => d.DisponibilidadEntrevistaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EntrevistasAsignadas_DisponibilidadEntrevistas");
        });

        modelBuilder.Entity<EntrevistasxInscripcion>(entity =>
        {
            entity.HasKey(e => e.EntrevistaInscripcionId);

            entity.ToTable("EntrevistasxInscripcion");

            entity.Property(e => e.AreasApoyo).IsUnicode(false);
            entity.Property(e => e.Concepto).IsUnicode(false);
            entity.Property(e => e.ConocelaU).IsUnicode(false);
            entity.Property(e => e.DesHinformaticas)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DesHInformaticas");
            entity.Property(e => e.DesOtraOp).IsUnicode(false);
            entity.Property(e => e.DesSegundoIdioma)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DesvAcademica)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaEntrevista).HasColumnType("datetime");
            entity.Property(e => e.Hinformaticas).HasColumnName("HInformaticas");
            entity.Property(e => e.Logros).IsUnicode(false);
            entity.Property(e => e.OtraInstitucion).IsUnicode(false);
            entity.Property(e => e.RazonesPgma).IsUnicode(false);
            entity.Property(e => e.RazonesU).IsUnicode(false);

            entity.HasOne(d => d.Entrevista).WithMany(p => p.EntrevistasxInscripcions)
                .HasForeignKey(d => d.EntrevistaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EntrevistasxInscripcion_Entrevistas");

            entity.HasOne(d => d.Inscripcion).WithMany(p => p.EntrevistasxInscripcions)
                .HasForeignKey(d => d.InscripcionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EntrevistasxInscripcion_Inscripciones");
        });

        modelBuilder.Entity<EntrevistasxPrograma>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EntrevistasxPrograma");

            entity.HasOne(d => d.Entrevista).WithMany()
                .HasForeignKey(d => d.EntrevistaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EntrevistasxPrograma_Entrevistas");

            entity.HasOne(d => d.Programa).WithMany()
                .HasForeignKey(d => d.ProgramaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EntrevistasxPrograma_Programas");
        });

        modelBuilder.Entity<EscalaResultado>(entity =>
        {
            entity.HasKey(e => e.EscalaId).HasName("PK_TiposRespuestasEvaluaciones");

            entity.ToTable(tb => tb.HasComment("Almacena las escalas asociadas a cada pregunta"));

            entity.Property(e => e.Abreviatura)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EscalasResultado>(entity =>
        {
            entity.HasKey(e => e.EscalaId);

            entity.Property(e => e.Abreviatura).HasMaxLength(50);
            entity.Property(e => e.Descripcion).HasMaxLength(200);
            entity.Property(e => e.DireccionRespuestas).HasMaxLength(50);
            entity.Property(e => e.Equivalencia).HasMaxLength(10);

            entity.HasOne(d => d.CalificacionTool).WithMany(p => p.EscalasResultados)
                .HasForeignKey(d => d.CalificacionToolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EscalasResultados_CalificacionTools");

            entity.HasOne(d => d.Pregunta).WithMany(p => p.EscalasResultados)
                .HasForeignKey(d => d.PreguntaId)
                .HasConstraintName("FK_EscalasResultados_Preguntas");
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasIndex(e => e.CodigoIes, "IX_Estados").IsUnique();

            entity.Property(e => e.CodigoIes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.HasOne(d => d.TipoEstado).WithMany(p => p.Estados)
                .HasForeignKey(d => d.TipoEstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Estados_TiposEstados");
        });

        modelBuilder.Entity<EstadoAsignatura>(entity =>
        {
            entity.ToTable("EstadoAsignatura");

            entity.Property(e => e.Descripcion).HasMaxLength(50);
        });

        modelBuilder.Entity<EstadosCivilesCrm>(entity =>
        {
            entity.HasKey(e => e.EstadoCivilId).HasName("PK_EstadosCiviles");

            entity.ToTable("EstadosCiviles_CRM");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadosPrograma>(entity =>
        {
            entity.HasKey(e => e.EstadoProgramaId);

            entity.HasIndex(e => e.CodigoIes, "IX_EstadosProgramas").IsUnique();

            entity.Property(e => e.CodigoIes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Etnia>(entity =>
        {
            entity.HasIndex(e => e.CodigoIes, "IX_Etnias").IsUnique();

            entity.Property(e => e.CodigoIes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(400)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EvaluacionDocente>(entity =>
        {
            entity.ToTable("EvaluacionDocente");

            entity.Property(e => e.Estado)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasComment("01-Activa, 02-Inactiva");
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Observaciones).HasMaxLength(200);
        });

        modelBuilder.Entity<EventLog>(entity =>
        {
            entity.ToTable("EventLog");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Tipo).HasMaxLength(50);
        });

        modelBuilder.Entity<Familiare>(entity =>
        {
            entity.HasKey(e => e.FamiliarId);

            entity.Property(e => e.DepartamentoId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MunicipioId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ocupacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaisId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrimerApellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrimerNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SegundoApellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SegundoNombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.NivelEducacion).WithMany(p => p.Familiares)
                .HasForeignKey(d => d.NivelEducacionId)
                .HasConstraintName("FK_Familiares_NivelesEducacion");

            entity.HasOne(d => d.Parentesco).WithMany(p => p.Familiares)
                .HasForeignKey(d => d.ParentescoId)
                .HasConstraintName("FK_Familiares_TiposParentesco");

            entity.HasOne(d => d.Persona).WithMany(p => p.Familiares)
                .HasForeignKey(d => d.PersonaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Familiares_Personas");
        });

        modelBuilder.Entity<Fase>(entity =>
        {
            entity.Property(e => e.Descripcion).HasMaxLength(200);
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.CalificacionTool).WithMany(p => p.Fases)
                .HasForeignKey(d => d.CalificacionToolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Fases_CalificacionTools");
        });

        modelBuilder.Entity<FormTool>(entity =>
        {
            entity.HasKey(e => e.FormToolId).HasFillFactor(90);

            entity.HasIndex(e => e.Nombre, "IX_FormTools_Nombre").IsUnique();

            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<FormToolDetail>(entity =>
        {
            entity.HasKey(e => e.FormToolDetailsId).HasFillFactor(90);

            entity.HasIndex(e => new { e.FormToolId, e.NombreCampo }, "IX_FormToolDetails").IsUnique();

            entity.Property(e => e.Descripcion).HasMaxLength(200);
            entity.Property(e => e.MostrarComo).HasMaxLength(50);
            entity.Property(e => e.NombreCampo).HasMaxLength(200);
            entity.Property(e => e.TipoCampo).HasMaxLength(50);
            entity.Property(e => e.TipoCampoCalculado).HasMaxLength(50);

            entity.HasOne(d => d.FormTool).WithMany(p => p.FormToolDetailFormTools)
                .HasForeignKey(d => d.FormToolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormToolDetails_FormTools");

            entity.HasOne(d => d.ListaFormTool).WithMany(p => p.FormToolDetailListaFormTools)
                .HasForeignKey(d => d.ListaFormToolId)
                .HasConstraintName("FK_FormToolDetails_FormTools1");
        });

        modelBuilder.Entity<FormToolDetailsOption>(entity =>
        {
            entity.HasKey(e => e.FormToolDetailsOptionsId).HasFillFactor(90);

            entity.HasOne(d => d.FormTollDetails).WithMany(p => p.FormToolDetailsOptions)
                .HasForeignKey(d => d.FormTollDetailsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormToolDetailsOptions_FormToolDetails");
        });

        modelBuilder.Entity<FormToolValue>(entity =>
        {
            entity.HasKey(e => e.FormToolValuesId).HasFillFactor(90);

            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.UserCreated).HasMaxLength(100);
            entity.Property(e => e.Usuario).HasMaxLength(100);

            entity.HasOne(d => d.FormTool).WithMany(p => p.FormToolValues)
                .HasForeignKey(d => d.FormToolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormToolValues_FormTools");
        });

        modelBuilder.Entity<FormToolValuesDetail>(entity =>
        {
            entity.HasKey(e => e.FormToolValuesDetailsId).HasFillFactor(90);

            entity.HasOne(d => d.FormTololDetail).WithMany(p => p.FormToolValuesDetails)
                .HasForeignKey(d => d.FormTololDetailId)
                .HasConstraintName("FK_FormToolValuesDetails_FormToolDetails");

            entity.HasOne(d => d.FormToolValues).WithMany(p => p.FormToolValuesDetails)
                .HasForeignKey(d => d.FormToolValuesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormToolValuesDetails_FormToolValues1");
        });

        modelBuilder.Entity<GenerosCrm>(entity =>
        {
            entity.HasKey(e => e.GeneroId).HasName("PK_Generos");

            entity.ToTable("Generos_CRM");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Graduando>(entity =>
        {
            entity.Property(e => e.Acta)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Folio)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.ActaGrado).WithMany(p => p.Graduandos)
                .HasForeignKey(d => d.ActaGradoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Graduandos_ActasGrado");

            entity.HasOne(d => d.Decano).WithMany(p => p.Graduandos)
                .HasForeignKey(d => d.DecanoId)
                .HasConstraintName("FK_Graduandos_Personas");

            entity.HasOne(d => d.Inscripcion).WithMany(p => p.Graduandos)
                .HasForeignKey(d => d.InscripcionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Graduandos_Inscripciones");
        });

        modelBuilder.Entity<Grupo>(entity =>
        {
            entity.HasKey(e => e.GrupoId).HasName("PK_GruposXAsignaturas");

            entity.Property(e => e.DescripcionGrupo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DocenteAsignaturaId).HasDefaultValue(323, "DF_Grupos_DocenteAsignaturaId");
            entity.Property(e => e.Estado).HasMaxLength(100);
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.FechaSolape).HasColumnType("datetime");
            entity.Property(e => e.Usuario).HasMaxLength(300);
            entity.Property(e => e.UsuarioSolape).HasMaxLength(300);

            entity.HasOne(d => d.AsignaturasxPrograma).WithMany(p => p.Grupos)
                .HasForeignKey(d => d.AsignaturasxProgramaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Grupos_AsignaturasxProgramas");

            entity.HasOne(d => d.DocenteAsignatura).WithMany(p => p.Grupos)
                .HasForeignKey(d => d.DocenteAsignaturaId)
                .HasConstraintName("FK_Grupos_DocentesxAsignatura");

            entity.HasOne(d => d.Jornada).WithMany(p => p.Grupos)
                .HasForeignKey(d => d.JornadaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Grupos_TiposJornadas");

            entity.HasOne(d => d.ModalidadCategoria).WithMany(p => p.Grupos)
                .HasForeignKey(d => d.ModalidadCategoriaId)
                .HasConstraintName("FK_Grupos_ModalidadesCategorias");

            entity.HasOne(d => d.Periodo).WithMany(p => p.Grupos)
                .HasForeignKey(d => d.PeriodoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Grupos_Periodo");
        });

        modelBuilder.Entity<GrupoXasistencium>(entity =>
        {
            entity.HasKey(e => e.GrupoXasistencia);

            entity.ToTable("GrupoXAsistencia");

            entity.Property(e => e.GrupoXasistencia).HasColumnName("GrupoXAsistencia");
            entity.Property(e => e.Concepto)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
        });

        modelBuilder.Entity<GruposPlane>(entity =>
        {
            entity.HasKey(e => e.GrupoPlanId);

            entity.Property(e => e.ActividadesTi)
                .HasMaxLength(2000)
                .HasColumnName("ActividadesTI");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Hti).HasColumnName("HTI");
            entity.Property(e => e.Htp).HasColumnName("HTP");
            entity.Property(e => e.Porcentaje).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Temas).HasMaxLength(2000);

            entity.HasOne(d => d.Grupo).WithMany(p => p.GruposPlanes)
                .HasForeignKey(d => d.GrupoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GruposPlanes_Grupos");

            entity.HasOne(d => d.TipoGrupoPlan).WithMany(p => p.GruposPlanes)
                .HasForeignKey(d => d.TipoGrupoPlanId)
                .HasConstraintName("FK_GruposPlanes_TiposGruposPlanes");
        });

        modelBuilder.Entity<GruposPlanesxArchivo>(entity =>
        {
            entity.HasKey(e => e.GrupoPlanArchivoId);

            entity.Property(e => e.NombreArchivo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Ruta)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TipoArchivo)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.GrupoPlan).WithMany(p => p.GruposPlanesxArchivos)
                .HasForeignKey(d => d.GrupoPlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GruposPlanesxArchivos_GruposPlanes");
        });

        modelBuilder.Entity<HerramientasxGrupo>(entity =>
        {
            entity.HasKey(e => e.HerramientaGrupoId);

            entity.ToTable("HerramientasxGrupo");

            entity.HasOne(d => d.CalificacionTool).WithMany(p => p.HerramientasxGrupos)
                .HasForeignKey(d => d.CalificacionToolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HerramientasxGrupo_CalificacionTools");

            entity.HasOne(d => d.Grupo).WithMany(p => p.HerramientasxGrupos)
                .HasForeignKey(d => d.GrupoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HerramientasxGrupo_Grupos");
        });

        modelBuilder.Entity<HistorialEstadosInscripcione>(entity =>
        {
            entity.HasKey(e => e.HistorialInscripcionId);

            entity.ToTable(tb => tb.HasComment("Contiene el histórico de los diferentes estados del proceso conforme la evolución de la inscripción"));

            entity.Property(e => e.HistorialInscripcionId)
                .HasComment("Consecutivo generado por el sistema")
                .HasColumnName("HistorialInscripcionID");
            entity.Property(e => e.FechaPcsoActual).HasComment("Fecha del proceso actual en el que se encuentra la inscripción");
            entity.Property(e => e.FechaPcsoAnterior).HasComment("Fecha del proceso anterior al proceso actual de la proceso de inscripción");
            entity.Property(e => e.FechaPcsoPosterior).HasComment("Fecha del proceso posterior al que evolucionó la inscripción");
            entity.Property(e => e.InscripcionId).HasComment("Consecutivo de la Inscripción");
            entity.Property(e => e.PcsoActual).HasComment("Proceso en el que se encuentra la inscripción");
            entity.Property(e => e.PcsoAnterior).HasComment("Proceso anterior al proceso actual de la proceso de inscripción");
            entity.Property(e => e.PcsoPosterior).HasComment("Proceso posterior al que evolucionó la inscripción");

            entity.HasOne(d => d.Inscripcion).WithMany(p => p.HistorialEstadosInscripciones)
                .HasForeignKey(d => d.InscripcionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistorialEstadosInscripciones_Inscripciones");
        });

        modelBuilder.Entity<HistorialInasistencium>(entity =>
        {
            entity.HasKey(e => e.HistorialInasistenciaId);

            entity.Property(e => e.FechaInasistencia).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.Usuario).HasMaxLength(150);

            entity.HasOne(d => d.InscritosGrupo).WithMany(p => p.HistorialInasistencia)
                .HasForeignKey(d => d.InscritosGrupoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistorialInasistencia_InscritosxGruposxAsignatura");

            entity.HasOne(d => d.Periodo).WithMany(p => p.HistorialInasistencia)
                .HasForeignKey(d => d.PeriodoId)
                .HasConstraintName("FK_HistorialInasistencia_Periodo");
        });

        modelBuilder.Entity<HistoricoNota>(entity =>
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("DeleteHistoricoNotas");
                    tb.HasTrigger("InsertHistoricoNotas");
                    tb.HasTrigger("UpdateHistoricoNotas");
                });

            entity.HasIndex(e => e.GrupoId, "GrupoId_NonClusteredIndex-20200430-104815");

            entity.HasIndex(e => e.InscripcionId, "InscripcionIdNonClustered");

            entity.Property(e => e.FechaCierreSemestre).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.Nota).HasColumnType("numeric(4, 2)");
            entity.Property(e => e.NotaAnversa).HasColumnType("numeric(4, 2)");
            entity.Property(e => e.Usuario).HasMaxLength(300);
            entity.Property(e => e.UsuarioCierreSemestre).HasMaxLength(300);

            entity.HasOne(d => d.AsignaturaRelacional).WithMany(p => p.HistoricoNota)
                .HasForeignKey(d => d.AsignaturaRelacionalId)
                .HasConstraintName("FK_HistoricoNotas_AsignaturasRelacionales");

            entity.HasOne(d => d.EstadoAsignatura).WithMany(p => p.HistoricoNota)
                .HasForeignKey(d => d.EstadoAsignaturaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistoricoNotas_EstadoAsignatura");

            entity.HasOne(d => d.Inscripcion).WithMany(p => p.HistoricoNota)
                .HasForeignKey(d => d.InscripcionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistoricoNotas_Inscripciones1");

            entity.HasOne(d => d.Matricula).WithMany(p => p.HistoricoNota)
                .HasForeignKey(d => d.MatriculaId)
                .HasConstraintName("FK_HistoricoNotas_Matriculas");

            entity.HasOne(d => d.Periodo).WithMany(p => p.HistoricoNota)
                .HasForeignKey(d => d.PeriodoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistoricoNotas_Periodo");

            entity.HasOne(d => d.PlanEstudioAsignatura).WithMany(p => p.HistoricoNota)
                .HasForeignKey(d => d.PlanEstudioAsignaturaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistoricoNotas_AsignaturasxPlanesEstudios1");
        });

        modelBuilder.Entity<Homologacione>(entity =>
        {
            entity.HasKey(e => e.HomologacionId);

            entity.Property(e => e.Codigo).HasMaxLength(300);
            entity.Property(e => e.CodigoActa).HasMaxLength(50);
            entity.Property(e => e.Descripcion).HasMaxLength(3000);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaActa).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.IeshomologacionId).HasColumnName("IESHomologacionId");
            entity.Property(e => e.Iesid).HasColumnName("IESId");
            entity.Property(e => e.PlanEstudio).HasMaxLength(500);
            entity.Property(e => e.Programa).HasMaxLength(500);
            entity.Property(e => e.TipoObjeto).HasMaxLength(100);
            entity.Property(e => e.Universidad).HasMaxLength(700);
            entity.Property(e => e.Usuario).HasMaxLength(300);

            entity.HasOne(d => d.Ieshomologacion).WithMany(p => p.HomologacioneIeshomologacions)
                .HasForeignKey(d => d.IeshomologacionId)
                .HasConstraintName("FK_Homologaciones_IESH1");

            entity.HasOne(d => d.Ies).WithMany(p => p.HomologacioneIes)
                .HasForeignKey(d => d.Iesid)
                .HasConstraintName("FK_Homologaciones_IES");

            entity.HasOne(d => d.Inscripcion).WithMany(p => p.Homologaciones)
                .HasForeignKey(d => d.InscripcionId)
                .HasConstraintName("FK_Homologaciones_Inscripciones");

            entity.HasOne(d => d.InstitucionAcademica).WithMany(p => p.Homologaciones)
                .HasForeignKey(d => d.InstitucionAcademicaId)
                .HasConstraintName("FK_Homologaciones_InstitucionesAcademicas");

            entity.HasOne(d => d.Periodo).WithMany(p => p.Homologaciones)
                .HasForeignKey(d => d.PeriodoId)
                .HasConstraintName("FK_Homologaciones_Periodo");

            entity.HasOne(d => d.PlanEstudioHomologacion).WithMany(p => p.HomologacionePlanEstudioHomologacions)
                .HasForeignKey(d => d.PlanEstudioHomologacionId)
                .HasConstraintName("FK_Homologaciones_PlanesEstudioH1");

            entity.HasOne(d => d.PlanEstudioNavigation).WithMany(p => p.HomologacionePlanEstudioNavigations)
                .HasForeignKey(d => d.PlanEstudioId)
                .HasConstraintName("FK_Homologaciones_PlanesEstudio");

            entity.HasOne(d => d.ProgramaHomologacion).WithMany(p => p.HomologacioneProgramaHomologacions)
                .HasForeignKey(d => d.ProgramaHomologacionId)
                .HasConstraintName("FK_Homologaciones_ProgramasH1");

            entity.HasOne(d => d.ProgramaNavigation).WithMany(p => p.HomologacioneProgramaNavigations)
                .HasForeignKey(d => d.ProgramaId)
                .HasConstraintName("FK_Homologaciones_Programas");
        });

        modelBuilder.Entity<HomologacionesDetalle>(entity =>
        {
            entity.HasKey(e => e.HomologacionDetalleId);

            entity.Property(e => e.Asignatura).HasMaxLength(600);
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.Nota).HasColumnType("numeric(4, 2)");
            entity.Property(e => e.NotaHomologada).HasColumnType("numeric(4, 2)");
            entity.Property(e => e.Periodo).HasMaxLength(50);
            entity.Property(e => e.Usuario).HasMaxLength(300);

            entity.HasOne(d => d.EstadoAsignatura).WithMany(p => p.HomologacionesDetalles)
                .HasForeignKey(d => d.EstadoAsignaturaId)
                .HasConstraintName("FK_HomologacionesDetalles_EstadoAsignatura1");

            entity.HasOne(d => d.HistoricoNota).WithMany(p => p.HomologacionesDetalles)
                .HasForeignKey(d => d.HistoricoNotaId)
                .HasConstraintName("FK_HomologacionesDetalles_HistoricoNotas");

            entity.HasOne(d => d.Homologacion).WithMany(p => p.HomologacionesDetalles)
                .HasForeignKey(d => d.HomologacionId)
                .HasConstraintName("FK_HomologacionesDetalles_Homologaciones");

            entity.HasOne(d => d.PeriodoNavigation).WithMany(p => p.HomologacionesDetalles)
                .HasForeignKey(d => d.PeriodoId)
                .HasConstraintName("FK_HomologacionesDetalles_Periodo");

            entity.HasOne(d => d.PlanEstudioAsignatura).WithMany(p => p.HomologacionesDetalles)
                .HasForeignKey(d => d.PlanEstudioAsignaturaId)
                .HasConstraintName("FK_HomologacionesDetalles_AsignaturasxPlanesEstudios");
        });

        modelBuilder.Entity<HorariosxDisponibilidadDocente>(entity =>
        {
            entity.HasKey(e => e.HorariosDisponibilidadDocenteId);

            entity.Property(e => e.HoraFin).HasColumnType("datetime");
            entity.Property(e => e.HoraInicio).HasColumnType("datetime");

            entity.HasOne(d => d.Dia).WithMany(p => p.HorariosxDisponibilidadDocentes)
                .HasForeignKey(d => d.DiaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HorariosxDisponibilidadDocentes_Dias");

            entity.HasOne(d => d.DisponibilidadDocente).WithMany(p => p.HorariosxDisponibilidadDocentes)
                .HasForeignKey(d => d.DisponibilidadDocenteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HorariosxDisponibilidadDocentes_DisponibilidadDocentes");

            entity.HasOne(d => d.Periodo).WithMany(p => p.HorariosxDisponibilidadDocentes)
                .HasForeignKey(d => d.PeriodoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HorariosxDisponibilidadDocentes_Periodo");
        });

        modelBuilder.Entity<HorariosxGrupo>(entity =>
        {
            entity.HasKey(e => e.HorarioGrupoId);

            entity.ToTable("HorariosxGrupo", tb =>
                {
                    tb.HasTrigger("InsertHorariosxGrupo");
                    tb.HasTrigger("UpdateHorariosxGrupo");
                });

            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.HoraFin).HasColumnType("datetime");
            entity.Property(e => e.HoraInicio).HasColumnType("datetime");
            entity.Property(e => e.Usuario).HasMaxLength(150);

            entity.HasOne(d => d.Ciclo).WithMany(p => p.HorariosxGrupos)
                .HasForeignKey(d => d.CicloId)
                .HasConstraintName("FK_HorariosxGrupo_ActividadesCalendario");

            entity.HasOne(d => d.Dia).WithMany(p => p.HorariosxGrupos)
                .HasForeignKey(d => d.DiaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HorariosxGrupo_Dias");

            entity.HasOne(d => d.Grupo).WithMany(p => p.HorariosxGrupos)
                .HasForeignKey(d => d.GrupoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HorariosxGrupo_Grupos");

            entity.HasOne(d => d.RecursoFisico).WithMany(p => p.HorariosxGrupos)
                .HasForeignKey(d => d.RecursoFisicoId)
                .HasConstraintName("FK_HorariosxGrupo_RecursosFisicos");
        });

        modelBuilder.Entity<Ie>(entity =>
        {
            entity.HasKey(e => e.EntidadEducacionId);

            entity.ToTable("IES", tb => tb.HasComment("Información de la Entidad de Educación Superior"));

            entity.HasIndex(e => e.CodigoIes, "IX_IES").IsUnique();

            entity.Property(e => e.AutoridadExpide)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CaracterAcademicoId).HasComment("Indica el carácter de las instituciones.");
            entity.Property(e => e.CodigoIes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("Identificación única de cada una de las Instituciones de Educación Superior, este código es asignado por el Ministerio de Educación Nacional")
                .HasColumnName("CodigoIES");
            entity.Property(e => e.CodigoIesprincipal)
                .HasComment("En el caso de que la IES no sea principal, debe ir el código de la IES padre")
                .HasColumnName("CodigoIESPrincipal");
            entity.Property(e => e.Direccion)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.EstatutoDocente)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.EstatutoGeneral)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.FechaAcreditacion).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion)
                .HasComment("Fecha en la cual nació jurídicamente la Institución de Educación Superior.")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaNorma).HasColumnType("datetime");
            entity.Property(e => e.Nit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Es la identificación que otorga la administración tributaria como contribuyente");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.NombreClave).HasMaxLength(100);
            entity.Property(e => e.NormaCreacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Normativa mediante la cual se le dió vida jurídica a la Institución de Educación Superior, en su calidad de tal.   ");
            entity.Property(e => e.Numero).HasComment("Número que identifica la norma anteriormente mencionada.");
            entity.Property(e => e.OrdenId).HasComment("Indica el origen  de las instituciones de educación superior, según su fuente de creación.");
            entity.Property(e => e.Principal).HasComment("01: Si es sede principal 02: s");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Reglamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReglamentoAdministrativo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReglamentoEstudiantil)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UrlAcreditacion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UrlActividadesCulturales)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UrlActividadesDeportivas)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UrlAreasSalud)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UrlAreasSociales)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UrlDirectorioAutoridades)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UrlEstatutoDocente)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UrlEstatutoGeneral)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UrlFinanciacion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UrlNorma)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UrlPaginaIstitucional)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("Dirección en Internet donde se pueda consultar el documento que define la Misión de la Institución. ");
            entity.Property(e => e.UrlProcesoAutoEvaluacion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UrlProcesosEleccionConformacionOrganosGobierno)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UrlProyeccionComunitaria)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UrlReglamento)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UrlReglamentoAdministrativo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UrlReglamentoEstudiantil)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UrlRequisitosIngresoAdmision)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.CaracterAcademico).WithMany(p => p.Ies)
                .HasForeignKey(d => d.CaracterAcademicoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IES_CaracterAcademico");

            entity.HasOne(d => d.Orden).WithMany(p => p.Ies)
                .HasForeignKey(d => d.OrdenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IES_Orden");

            entity.HasOne(d => d.TipoAcreditacion).WithMany(p => p.Ies)
                .HasForeignKey(d => d.TipoAcreditacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IES_TipoAcreditacion");

            entity.HasOne(d => d.TipoNormaLegal).WithMany(p => p.Ies)
                .HasForeignKey(d => d.TipoNormaLegalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IES_TipoNormaLegal");

            entity.HasOne(d => d.TipoReglamento).WithMany(p => p.Ies)
                .HasForeignKey(d => d.TipoReglamentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IES_TipoReglamentoOpcional");
        });

        modelBuilder.Entity<InformacionAcademica>(entity =>
        {
            entity.HasKey(e => e.InformacionAcademicaId).HasName("PK_InformacionesAcademicas");

            entity.ToTable("InformacionAcademica");

            entity.Property(e => e.AnoGrado)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AnoIcfes)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DepartamentoId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaIcfes).HasColumnType("datetime");
            entity.Property(e => e.MunicipioId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreInstitucion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PaisId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Snp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SNP");
            entity.Property(e => e.Titulo)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.NivelEducacion).WithMany(p => p.InformacionAcademicas)
                .HasForeignKey(d => d.NivelEducacionId)
                .HasConstraintName("FK_InformacionAcademica_NivelesEducacion");

            entity.HasOne(d => d.Persona).WithMany(p => p.InformacionAcademicas)
                .HasForeignKey(d => d.PersonaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InformacionAcademica_Personas");

            entity.HasOne(d => d.TipoInstitucion).WithMany(p => p.InformacionAcademicas)
                .HasForeignKey(d => d.TipoInstitucionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InformacionAcademica_Origen");
        });

        modelBuilder.Entity<InformacionAdicional>(entity =>
        {
            entity.HasKey(e => e.InformacionAdicionalId).HasName("PK_InformaciónAdicional");

            entity.ToTable("InformacionAdicional");

            entity.Property(e => e.DepartamentoId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntidadCreditoId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MunicipioId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaisFronteraId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RazonPresentacion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ValorPagadoIes)
                .HasColumnType("decimal(15, 0)")
                .HasColumnName("ValorPagadoIES");

            entity.HasOne(d => d.Capacidad).WithMany(p => p.InformacionAdicionals)
                .HasForeignKey(d => d.CapacidadId)
                .HasConstraintName("FK_InformaciónAdicional_Capacidades");

            entity.HasOne(d => d.DiscapacidadNavigation).WithMany(p => p.InformacionAdicionals)
                .HasForeignKey(d => d.DiscapacidadId)
                .HasConstraintName("FK_InformacionAdicional_Discapacidades");

            entity.HasOne(d => d.Etnia).WithMany(p => p.InformacionAdicionals)
                .HasForeignKey(d => d.EtniaId)
                .HasConstraintName("FK_InformaciónAdicional_Etnias");

            entity.HasOne(d => d.Persona).WithMany(p => p.InformacionAdicionals)
                .HasForeignKey(d => d.PersonaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InformaciónAdicional_Personas");

            entity.HasOne(d => d.RangosHermano).WithMany(p => p.InformacionAdicionals)
                .HasForeignKey(d => d.RangosHermanoId)
                .HasConstraintName("FK_InformaciónAdicional_RangosHermanos");
        });

        modelBuilder.Entity<InformacionLaboral>(entity =>
        {
            entity.ToTable("InformacionLaboral");

            entity.Property(e => e.Cargo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Empresa)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JefeInmediato)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RangoIngreso)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.DuracionNavigation).WithMany(p => p.InformacionLaborals)
                .HasForeignKey(d => d.Duracion)
                .HasConstraintName("FK_InformacionLaboral_Duracion");

            entity.HasOne(d => d.Persona).WithMany(p => p.InformacionLaborals)
                .HasForeignKey(d => d.PersonaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InformacionLaboral_Personas");

            entity.HasOne(d => d.TipoTrabajo).WithMany(p => p.InformacionLaborals)
                .HasForeignKey(d => d.TipoTrabajoId)
                .HasConstraintName("FK_InformacionLaboral_TiposTrabajos");
        });

        modelBuilder.Entity<Inscripcione>(entity =>
        {
            entity.HasKey(e => e.InscripcionId);

            entity.ToTable(tb => tb.HasTrigger("InsertConsecutivoSemestral"));

            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.MedioDifusion)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NumeroFormulario).HasMaxLength(100);
            entity.Property(e => e.Observaciones).HasMaxLength(200);

            entity.HasOne(d => d.Antiguedad).WithMany(p => p.Inscripciones)
                .HasForeignKey(d => d.AntiguedadId)
                .HasConstraintName("FK_Inscripciones_Antiguedades");

            entity.HasOne(d => d.Cubrimiento).WithMany(p => p.Inscripciones)
                .HasForeignKey(d => d.CubrimientoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inscripciones_CubrimientoxPrograma");

            entity.HasOne(d => d.Jornada).WithMany(p => p.Inscripciones)
                .HasForeignKey(d => d.JornadaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inscripciones_TiposJornadas");

            entity.HasOne(d => d.Modalidad).WithMany(p => p.Inscripciones)
                .HasForeignKey(d => d.ModalidadId)
                .HasConstraintName("FK_Inscripciones_Modalidades");

            entity.HasOne(d => d.Periodo).WithMany(p => p.Inscripciones)
                .HasForeignKey(d => d.PeriodoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inscripciones_Periodo");

            entity.HasOne(d => d.Persona).WithMany(p => p.Inscripciones)
                .HasForeignKey(d => d.PersonaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inscripciones_Personas");

            entity.HasOne(d => d.Programa).WithMany(p => p.Inscripciones)
                .HasForeignKey(d => d.ProgramaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inscripciones_Programas");

            entity.HasOne(d => d.TipoInscripcion).WithMany(p => p.Inscripciones)
                .HasForeignKey(d => d.TipoInscripcionId)
                .HasConstraintName("FK_Inscripciones_TiposInscripción");
        });

        modelBuilder.Entity<InscripcionesResumenAcademico>(entity =>
        {
            entity.HasKey(e => e.InscripcionResumenAcademico);

            entity.ToTable("InscripcionesResumenAcademico");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.PeriodosAcumulados).HasMaxLength(200);
            entity.Property(e => e.Usuario).HasMaxLength(200);

            entity.HasOne(d => d.Inscripcion).WithMany(p => p.InscripcionesResumenAcademicos)
                .HasForeignKey(d => d.InscripcionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InscripcionesResumenAcademico_Inscripciones");

            entity.HasOne(d => d.PeriodoIdPrimeraMatriculaNavigation).WithMany(p => p.InscripcionesResumenAcademicoPeriodoIdPrimeraMatriculaNavigations)
                .HasForeignKey(d => d.PeriodoIdPrimeraMatricula)
                .HasConstraintName("FK_InscripcionesResumenAcademico_Periodo");

            entity.HasOne(d => d.PeriodoIdUltimaMatriculaNavigation).WithMany(p => p.InscripcionesResumenAcademicoPeriodoIdUltimaMatriculaNavigations)
                .HasForeignKey(d => d.PeriodoIdUltimaMatricula)
                .HasConstraintName("FK_InscripcionesResumenAcademico_Periodo1");
        });

        modelBuilder.Entity<InscripcionesxActasGrado>(entity =>
        {
            entity.HasKey(e => e.InscripcionxActaGradoId);

            entity.ToTable("InscripcionesxActasGrado");

            entity.Property(e => e.Folio)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.ActaGrado).WithMany(p => p.InscripcionesxActasGrados)
                .HasForeignKey(d => d.ActaGradoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InscripcionesxActasGrado_ActasGrado");

            entity.HasOne(d => d.Inscripcion).WithMany(p => p.InscripcionesxActasGrados)
                .HasForeignKey(d => d.InscripcionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InscripcionesxActasGrado_Inscripciones");
        });

        modelBuilder.Entity<InscripcionxProceso>(entity =>
        {
            entity.HasKey(e => e.InscrpcionxProcesoId);

            entity.ToTable("InscripcionxProceso", tb => tb.HasComment("Almacena los diferentes estados en el que se encuentra una inscripción"));

            entity.Property(e => e.InscrpcionxProcesoId).HasComment("Cosecutivo generado por el sistema");
            entity.Property(e => e.InscripcionId).HasComment("Consecutivo de la inscripción");
            entity.Property(e => e.ProcesoId).HasComment("Consecutivo asociado a la insciprción");

            entity.HasOne(d => d.Inscripcion).WithMany(p => p.InscripcionxProcesos)
                .HasForeignKey(d => d.InscripcionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InscripcionxProceso_Inscripciones");

            entity.HasOne(d => d.Proceso).WithMany(p => p.InscripcionxProcesos)
                .HasForeignKey(d => d.ProcesoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InscripcionxProceso_Proceso");
        });

        modelBuilder.Entity<InscritosxGruposxAsignatura>(entity =>
        {
            entity.HasKey(e => e.InscritosGrupoId).HasName("PK_GruposXEstudiantes");

            entity.ToTable("InscritosxGruposxAsignatura");

            entity.HasOne(d => d.Grupo).WithMany(p => p.InscritosxGruposxAsignaturas)
                .HasForeignKey(d => d.GrupoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InscritosxGruposxAsignatura_Grupos");

            entity.HasOne(d => d.Inscripcion).WithMany(p => p.InscritosxGruposxAsignaturas)
                .HasForeignKey(d => d.InscripcionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InscritosxGrupos_Inscripciones");

            entity.HasOne(d => d.Matricula).WithMany(p => p.InscritosxGruposxAsignaturas)
                .HasForeignKey(d => d.MatriculaId)
                .HasConstraintName("FK_InscritosxGruposxAsignatura_Matriculas");
        });

        modelBuilder.Entity<InstitucionesAcademica>(entity =>
        {
            entity.HasKey(e => e.InstitucionAcademicaId);

            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.Departamento).HasMaxLength(150);
            entity.Property(e => e.Direccion).HasMaxLength(150);
            entity.Property(e => e.Estado).HasComment("Activa/Inactiva");
            entity.Property(e => e.Municipio).HasMaxLength(150);
            entity.Property(e => e.MunicipioCodigo).HasMaxLength(50);
            entity.Property(e => e.Nit).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(350);
            entity.Property(e => e.Telefono).HasMaxLength(50);

            entity.HasOne(d => d.Orden).WithMany(p => p.InstitucionesAcademicas)
                .HasForeignKey(d => d.OrdenId)
                .HasConstraintName("FK_InstitucionesAcademicas_Orden");

            entity.HasOne(d => d.Origen).WithMany(p => p.InstitucionesAcademicas)
                .HasForeignKey(d => d.OrigenId)
                .HasConstraintName("FK_InstitucionesAcademicas_Origen");
        });

        modelBuilder.Entity<Justificacione>(entity =>
        {
            entity.HasKey(e => e.JustificacionId);

            entity.HasIndex(e => e.CodigoIes, "IX_Justificaciones").IsUnique();

            entity.Property(e => e.CodigoIes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LineasProfundizacion>(entity =>
        {
            entity.HasKey(e => e.LineaId);

            entity.ToTable("LineasProfundizacion");

            entity.Property(e => e.NombreLinea).HasMaxLength(150);

            entity.HasOne(d => d.AsignaturaPlanEstudio).WithMany(p => p.LineasProfundizacions)
                .HasForeignKey(d => d.AsignaturaPlanEstudioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LineasProfundizacion_AsignaturasxPlanesEstudios");
        });

        modelBuilder.Entity<Liquidacione>(entity =>
        {
            entity.HasKey(e => e.LiquidacionId).HasName("PK_Matriculados");

            entity.ToTable(tb => tb.HasComment("Contiene las diferentes liquidaciones que se han generado para una inscripción"));

            entity.Property(e => e.LiquidacionId).HasComment("Consecutivo generado por el sistema");
            entity.Property(e => e.Cobros).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ConceptoErp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ConceptoERP");
            entity.Property(e => e.DescuentoComercial).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Descuentos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EstadoId).HasComment("Consecutivo que almacena el estado de la inscripción:  Pendiente de pago, pagada");
            entity.Property(e => e.ExtemporaneoDosFechaVencimiento).HasColumnType("datetime");
            entity.Property(e => e.ExtemporaneoDosIncremento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ExtemporaneoDosIncrementoPorcentaje).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ExtemporaneoIncremento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ExtemporaneoIncrementoPorcentaje).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FechaGeneracion)
                .HasComment("Fecha en la que se genera la liquidación")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaGeneracionFactura).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.FechaPago).HasComment("Fecha en la que se paga el valor de la inscripción");
            entity.Property(e => e.FechaRequest).HasColumnType("datetime");
            entity.Property(e => e.InscripcionId).HasComment("Corresponde al Identificador de la inscripción, de la matrícula");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IVA");
            entity.Property(e => e.ProcessUrl)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("ProcessURL");
            entity.Property(e => e.ProntoPagoDescuento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProntoPagoDescuentoPorcentaje).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProntoPagoDosDescuento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProntoPagoDosDescuentoPorcentaje).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProntoPagoUnoDescuento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProntoPagoUnoDescuentoPorcentaje).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Reference)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RequestId).HasColumnName("RequestID");
            entity.Property(e => e.SEstado)
                .HasMaxLength(10)
                .HasColumnName("s_estado");
            entity.Property(e => e.SEstadoFactura)
                .HasMaxLength(10)
                .HasColumnName("s_estadoFactura");
            entity.Property(e => e.SFuente)
                .HasMaxLength(50)
                .HasColumnName("s_fuente");
            entity.Property(e => e.SFuenteFactura)
                .HasMaxLength(50)
                .HasColumnName("s_fuenteFactura");
            entity.Property(e => e.SIdentificador)
                .HasMaxLength(50)
                .HasColumnName("s_identificador");
            entity.Property(e => e.SIdentificadorFactura)
                .HasMaxLength(50)
                .HasColumnName("s_identificadorFactura");
            entity.Property(e => e.SLMovimiento)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("s_l_movimiento");
            entity.Property(e => e.SMensaje)
                .HasMaxLength(800)
                .HasColumnName("s_mensaje");
            entity.Property(e => e.SMensajeFactura)
                .HasMaxLength(800)
                .HasColumnName("s_mensajeFactura");
            entity.Property(e => e.SNumDocumento)
                .HasMaxLength(50)
                .HasColumnName("s_num_documento");
            entity.Property(e => e.SNumDocumentoFactura)
                .HasMaxLength(50)
                .HasColumnName("s_num_documentoFactura");
            entity.Property(e => e.TiposLiquidacionId).HasComment("Contiene los diferentes tipos de liquidaciónes que se han generado para una inscripción: liquidación por pago de inscripción, matrícula y adiciones.");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usuario).HasMaxLength(300);
            entity.Property(e => e.Valor).HasComment("Valor asociado a la liquidación generada");

            entity.HasOne(d => d.Estado).WithMany(p => p.Liquidaciones)
                .HasForeignKey(d => d.EstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Liquidaciones_Estados");

            entity.HasOne(d => d.Inscripcion).WithMany(p => p.Liquidaciones)
                .HasForeignKey(d => d.InscripcionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Liquidaciones_Inscripciones1");

            entity.HasOne(d => d.Matricula).WithMany(p => p.Liquidaciones)
                .HasForeignKey(d => d.MatriculaId)
                .HasConstraintName("FK_Liquidaciones_Matriculas");

            entity.HasOne(d => d.Periodo).WithMany(p => p.Liquidaciones)
                .HasForeignKey(d => d.PeriodoId)
                .HasConstraintName("FK_LiquidacionesPeriodos");

            entity.HasOne(d => d.TiposLiquidacion).WithMany(p => p.Liquidaciones)
                .HasForeignKey(d => d.TiposLiquidacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Liquidaciones_TiposLiquidacion");
        });

        modelBuilder.Entity<ListasTool>(entity =>
        {
            entity.HasKey(e => e.ListaToolId).HasFillFactor(90);

            entity.HasIndex(e => e.Nombre, "IX_ListasTools_Nombre").IsUnique();

            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<ListasToolDetail>(entity =>
        {
            entity.HasKey(e => e.ListaToolDetailsId).HasFillFactor(90);

            entity.HasIndex(e => new { e.ListaToolId, e.Texto }, "IX_ListasToolDetails_Texto").IsUnique();

            entity.Property(e => e.Texto).HasMaxLength(200);

            entity.HasOne(d => d.ListaTool).WithMany(p => p.ListasToolDetails)
                .HasForeignKey(d => d.ListaToolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ListasToolDetails_ListasTools");
        });

        modelBuilder.Entity<Matricula>(entity =>
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("InsertMatriculas");
                    tb.HasTrigger("UpdateMatriculas");
                });

            entity.HasIndex(e => e.PeriodoId, "NonClusteredIndexPeriodoId");

            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.Concepto)
                .HasMaxLength(50)
                .HasComment("MATRICULA, INSCRIPCION, ADICION");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaAsentada).HasColumnType("datetime");
            entity.Property(e => e.FechaCancelada).HasColumnType("datetime");
            entity.Property(e => e.FechaPromedio).HasColumnType("datetime");
            entity.Property(e => e.NotaPromedio).HasColumnType("numeric(4, 2)");
            entity.Property(e => e.Rol).HasMaxLength(150);
            entity.Property(e => e.UsuarioAsentada).HasMaxLength(150);
            entity.Property(e => e.UsuarioCancelada).HasMaxLength(150);
            entity.Property(e => e.UsuarioMatricula).HasMaxLength(150);
            entity.Property(e => e.UsuarioPromedio).HasMaxLength(300);

            entity.HasOne(d => d.Antiguedad).WithMany(p => p.Matriculas)
                .HasForeignKey(d => d.AntiguedadId)
                .HasConstraintName("FK_Matriculas_Antiguedades");

            entity.HasOne(d => d.Estado).WithMany(p => p.Matriculas)
                .HasForeignKey(d => d.EstadoId)
                .HasConstraintName("FK_Matriculas_Estados");

            entity.HasOne(d => d.Inscripcion).WithMany(p => p.Matriculas)
                .HasForeignKey(d => d.InscripcionId)
                .HasConstraintName("FK_Matriculas_Inscripciones");

            entity.HasOne(d => d.Jornada).WithMany(p => p.Matriculas)
                .HasForeignKey(d => d.JornadaId)
                .HasConstraintName("FK_Matriculas_Jornadas");

            entity.HasOne(d => d.ModalidadCategoria).WithMany(p => p.Matriculas)
                .HasForeignKey(d => d.ModalidadCategoriaId)
                .HasConstraintName("FK_Matriculas_ModalidadesCategorias");

            entity.HasOne(d => d.Periodo).WithMany(p => p.Matriculas)
                .HasForeignKey(d => d.PeriodoId)
                .HasConstraintName("FK_Matriculas_Periodo");

            entity.HasOne(d => d.PlanEstudio).WithMany(p => p.Matriculas)
                .HasForeignKey(d => d.PlanEstudioId)
                .HasConstraintName("FK_Matriculas_PlanesEstudio");

            entity.HasOne(d => d.TipoIngreso).WithMany(p => p.Matriculas)
                .HasForeignKey(d => d.TipoIngresoId)
                .HasConstraintName("FK_Matriculas_TiposInscripcion");

            entity.HasOne(d => d.TipoPago).WithMany(p => p.Matriculas)
                .HasForeignKey(d => d.TipoPagoId)
                .HasConstraintName("FK_Matriculas_TiposPagos");
        });

        modelBuilder.Entity<MatriculasAcceso>(entity =>
        {
            entity.HasKey(e => e.MatriculaAccesoId);

            entity.ToTable("MatriculasAcceso", tb =>
                {
                    tb.HasTrigger("DeleteMatriculasAcceso");
                    tb.HasTrigger("InsertMatriculasAcceso");
                    tb.HasTrigger("UpdateMatriculasAcceso");
                });

            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.Usuario).HasMaxLength(250);

            entity.HasOne(d => d.Inscripcion).WithMany(p => p.MatriculasAccesos)
                .HasForeignKey(d => d.InscripcionId)
                .HasConstraintName("FK_MatriculasAcceso_Inscripciones");

            entity.HasOne(d => d.Periodo).WithMany(p => p.MatriculasAccesos)
                .HasForeignKey(d => d.PeriodoId)
                .HasConstraintName("FK_MatriculasAcceso_Periodo");
        });

        modelBuilder.Entity<MediosDifusionCrm>(entity =>
        {
            entity.HasKey(e => e.MedioDifusionId).HasName("PK_MediosDifusion");

            entity.ToTable("MediosDifusion_CRM");

            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Modalidade>(entity =>
        {
            entity.HasKey(e => e.ModalidadId);

            entity.HasIndex(e => e.CodigoIes, "IX_Modalidades").IsUnique();

            entity.Property(e => e.CodigoIes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ModalidadesCategoria>(entity =>
        {
            entity.HasKey(e => e.ModalidadCategoriaId);

            entity.Property(e => e.NombreModalidad).HasMaxLength(50);
        });

        modelBuilder.Entity<MultimediaMatriculaContrato>(entity =>
        {
            entity.HasKey(e => e.MultimediaContratoId).HasName("PK_MultimediaContratoId");

            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.HasOne(d => d.Periodo).WithMany(p => p.MultimediaMatriculaContratos)
                .HasForeignKey(d => d.PeriodoId)
                .HasConstraintName("FK_MultimediaMatriculaContratosPeriodos");
        });

        modelBuilder.Entity<Multimedium>(entity =>
        {
            entity.HasKey(e => e.MultimediaId);

            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.HasOne(d => d.Periodo).WithMany(p => p.Multimedia)
                .HasForeignKey(d => d.PeriodoId)
                .HasConstraintName("FK_MultimediaPeriodos");
        });

        modelBuilder.Entity<MunicipiosCrm>(entity =>
        {
            entity.HasKey(e => e.MunicipioId).HasName("PK_Municipios");

            entity.ToTable("Municipios_CRM");

            entity.HasIndex(e => e.Codigo, "IX_Municipios_Codigo_CRM");

            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.CodigoDpta).HasMaxLength(50);
            entity.Property(e => e.CodigoPais).HasMaxLength(50);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionDpta).HasMaxLength(150);
            entity.Property(e => e.DescripcionPais).HasMaxLength(150);

            entity.HasOne(d => d.Departamento).WithMany(p => p.MunicipiosCrms)
                .HasForeignKey(d => d.DepartamentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Municipios_Departamentos");
        });

        modelBuilder.Entity<Nbc>(entity =>
        {
            entity.HasKey(e => e.Nbcid).HasName("PK_NivelesBasicosConocimiento");

            entity.ToTable("NBC");

            entity.HasIndex(e => e.CodigoIes, "IX_NBC").IsUnique();

            entity.Property(e => e.Nbcid).HasColumnName("NBCId");
            entity.Property(e => e.CodigoIes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.AreaConocimiento).WithMany(p => p.Nbcs)
                .HasForeignKey(d => d.AreaConocimientoId)
                .HasConstraintName("FK_NBC_AreasNBC");
        });

        modelBuilder.Entity<NivelesEducacion>(entity =>
        {
            entity.HasKey(e => e.NivelEducacionId);

            entity.ToTable("NivelesEducacion");

            entity.HasIndex(e => e.CodigoIes, "IX_NivelesEducacion").IsUnique();

            entity.Property(e => e.CodigoIes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Distincion).HasMaxLength(100);
        });

        modelBuilder.Entity<NivelesEstudio>(entity =>
        {
            entity.HasKey(e => e.NivelEstudioId);

            entity.ToTable("NivelesEstudio");

            entity.Property(e => e.CodigoIes)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Nota>(entity =>
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("InsertNota");
                    tb.HasTrigger("UpdateNota");
                });

            entity.HasIndex(e => e.InscritosGrupoId, "InscritoGrupoId_add_NonClusteredIndex-20200430-110300");

            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.Nota1)
                .HasColumnType("numeric(3, 2)")
                .HasColumnName("Nota");
            entity.Property(e => e.Usuario).HasMaxLength(150);

            entity.HasOne(d => d.InscritosGrupo).WithMany(p => p.Nota)
                .HasForeignKey(d => d.InscritosGrupoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Notas_InscritosxGruposxAsignatura");

            entity.HasOne(d => d.Periodod).WithMany(p => p.Nota)
                .HasForeignKey(d => d.PeriododId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Notas_Periodo");

            entity.HasOne(d => d.Seguimiento).WithMany(p => p.Nota)
                .HasForeignKey(d => d.SeguimientoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Notas_ProgramacionEvaluacion");
        });

        modelBuilder.Entity<NotasPrueba>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Notas_Prueba");

            entity.Property(e => e.Nota).HasColumnType("numeric(3, 2)");
        });

        modelBuilder.Entity<NovedadesNota>(entity =>
        {
            entity.HasKey(e => e.NovedadNotaId);

            entity.Property(e => e.FechaAprobacion).HasColumnType("datetime");
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");
            entity.Property(e => e.ObservacionesAprobacion).HasMaxLength(500);
            entity.Property(e => e.ObservacionesSolicitud).HasMaxLength(500);
            entity.Property(e => e.TipoNovedad)
                .HasMaxLength(50)
                .HasComment("TipoNovedad: Grupal: Habilitar todas las notas del grupo. TipoEvaluacion: Habilitar por Tipo Evaluación (Seguimiento I ó Seguimiento II o Final o Parcial) Estudiante: Habilitar todas las notas de un estudiante. Puntual: Habilitar el ingreso de una sola nota.");
            entity.Property(e => e.UsuarioAprobacion).HasMaxLength(80);
            entity.Property(e => e.UsuarioSolicitud).HasMaxLength(80);

            entity.HasOne(d => d.EstadoSolicitud).WithMany(p => p.NovedadesNota)
                .HasForeignKey(d => d.EstadoSolicitudId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NovedadesNotas_Estados");

            entity.HasOne(d => d.Periodo).WithMany(p => p.NovedadesNota)
                .HasForeignKey(d => d.PeriodoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NovedadesNotas_Periodo");
        });

        modelBuilder.Entity<NovedadesNotasDetalle>(entity =>
        {
            entity.HasKey(e => e.NovedadNotaDetalleId);

            entity.Property(e => e.NotaNueva).HasColumnType("numeric(3, 2)");

            entity.HasOne(d => d.Grupo).WithMany(p => p.NovedadesNotasDetalles)
                .HasForeignKey(d => d.GrupoId)
                .HasConstraintName("FK_NovedadesNotasDetalles_Grupos");

            entity.HasOne(d => d.InscritosGrupo).WithMany(p => p.NovedadesNotasDetalles)
                .HasForeignKey(d => d.InscritosGrupoId)
                .HasConstraintName("FK_NovedadesNotasDetalles_InscritosxGruposxAsignatura");

            entity.HasOne(d => d.Nota).WithMany(p => p.NovedadesNotasDetalles)
                .HasForeignKey(d => d.NotaId)
                .HasConstraintName("FK_NovedadesNotasDetalles_Notas");

            entity.HasOne(d => d.NovedadNota).WithMany(p => p.NovedadesNotasDetalles)
                .HasForeignKey(d => d.NovedadNotaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NovedadesNotasDetalles_NovedadesNotas");

            entity.HasOne(d => d.TipoEvaluacion).WithMany(p => p.NovedadesNotasDetalles)
                .HasForeignKey(d => d.TipoEvaluacionId)
                .HasConstraintName("FK_NovedadesNotasDetalles_TipoEvaluacion");
        });

        modelBuilder.Entity<OcupacionxDocente>(entity =>
        {
            entity.HasKey(e => e.OcupacionDocenteId).HasName("PK_OcupacionXDocente");

            entity.ToTable("OcupacionxDocente", tb => tb.HasComment("Almacena la disponibilidad y ocupación de los docentes"));

            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.Recurrencia)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Usuario).HasMaxLength(150);

            entity.HasOne(d => d.Ciclo).WithMany(p => p.OcupacionxDocentes)
                .HasForeignKey(d => d.CicloId)
                .HasConstraintName("FK_OcupacionxDocente_ActividadesCalendario");

            entity.HasOne(d => d.Dia).WithMany(p => p.OcupacionxDocentes)
                .HasForeignKey(d => d.DiaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OcupacionxDocente_Dias");

            entity.HasOne(d => d.Periodo).WithMany(p => p.OcupacionxDocentes)
                .HasForeignKey(d => d.PeriodoId)
                .HasConstraintName("FK_OcupacionxDocente_Periodo");

            entity.HasOne(d => d.Persona).WithMany(p => p.OcupacionxDocentes)
                .HasForeignKey(d => d.PersonaId)
                .HasConstraintName("FK_OcupacionxDocente_PersonaId");

            entity.HasOne(d => d.Programa).WithMany(p => p.OcupacionxDocentes)
                .HasForeignKey(d => d.ProgramaId)
                .HasConstraintName("FK_OcupacionxDocente_ProgramaId");

            entity.HasOne(d => d.TipoOcupacionDocente).WithMany(p => p.OcupacionxDocentes)
                .HasForeignKey(d => d.TipoOcupacionDocenteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OcupacionxDocente_TipoOcupacionDocente");
        });

        modelBuilder.Entity<OcupacionxRecursoFisico>(entity =>
        {
            entity.HasKey(e => e.OcupacionRecursoFisicoId).HasName("PK_OcupacionXAulas");

            entity.ToTable("OcupacionxRecursoFisico", tb => tb.HasComment("Almacena la disponibilidad y ocupación del los recursos físicos"));

            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.Recurrencia)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Usuario).HasMaxLength(150);

            entity.HasOne(d => d.Ciclo).WithMany(p => p.OcupacionxRecursoFisicos)
                .HasForeignKey(d => d.CicloId)
                .HasConstraintName("FK_OcupacionxRecursoFisico_ActividadesCalendario");

            entity.HasOne(d => d.Dia).WithMany(p => p.OcupacionxRecursoFisicos)
                .HasForeignKey(d => d.DiaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OcupacionxRecursoFisico_Dias");

            entity.HasOne(d => d.Persona).WithMany(p => p.OcupacionxRecursoFisicos)
                .HasForeignKey(d => d.PersonaId)
                .HasConstraintName("FK_OcupacionxRecursoFisico_PersonaId");

            entity.HasOne(d => d.RecursoFisico).WithMany(p => p.OcupacionxRecursoFisicos)
                .HasForeignKey(d => d.RecursoFisicoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OcupacionxRecursoFisico_RecursosFisicos");

            entity.HasOne(d => d.TipoOcupacion).WithMany(p => p.OcupacionxRecursoFisicos)
                .HasForeignKey(d => d.TipoOcupacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OcupacionxRecursoFisico_TipoOcupacion");
        });

        modelBuilder.Entity<Orden>(entity =>
        {
            entity.ToTable("Orden");

            entity.HasIndex(e => e.CodigoIes, "IX_Orden").IsUnique();

            entity.Property(e => e.CodigoIes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Origen).WithMany(p => p.Ordens)
                .HasForeignKey(d => d.OrigenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orden_Origen1");
        });

        modelBuilder.Entity<Origen>(entity =>
        {
            entity.ToTable("Origen");

            entity.HasIndex(e => e.CodigoIes, "IX_Origen").IsUnique();

            entity.Property(e => e.CodigoIes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PaisFronteraCrm>(entity =>
        {
            entity.HasKey(e => e.PaisFronteraId);

            entity.ToTable("PaisFrontera_CRM");

            entity.Property(e => e.Descripcion).HasMaxLength(50);

            entity.HasOne(d => d.Pais).WithMany(p => p.PaisFronteraCrms)
                .HasForeignKey(d => d.PaisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PaisFrontera_CRM_Paises_CRM");
        });

        modelBuilder.Entity<PaisesCrm>(entity =>
        {
            entity.HasKey(e => e.PaisId).HasName("PK_Paises");

            entity.ToTable("Paises_CRM");

            entity.HasIndex(e => e.Codigo, "IX_Paises_Codigo_CRM");

            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.CodigoSnies)
                .HasMaxLength(50)
                .HasColumnName("CodigoSNIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Parametro>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones).HasMaxLength(500);
            entity.Property(e => e.TipoParametro).HasMaxLength(100);

            entity.HasOne(d => d.EntidadEducacion).WithMany(p => p.Parametros)
                .HasForeignKey(d => d.EntidadEducacionId)
                .HasConstraintName("FK_Parametros_IES");
        });

        modelBuilder.Entity<Pbcatcol>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pbcatcol");

            entity.HasIndex(e => new { e.PbcTnam, e.PbcOwnr, e.PbcCnam }, "pbcatc_x").IsUnique();

            entity.Property(e => e.PbcBmap)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("pbc_bmap");
            entity.Property(e => e.PbcCase).HasColumnName("pbc_case");
            entity.Property(e => e.PbcCid).HasColumnName("pbc_cid");
            entity.Property(e => e.PbcCmnt)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbc_cmnt");
            entity.Property(e => e.PbcCnam)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("pbc_cnam");
            entity.Property(e => e.PbcEdit)
                .HasMaxLength(31)
                .IsUnicode(false)
                .HasColumnName("pbc_edit");
            entity.Property(e => e.PbcHdr)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbc_hdr");
            entity.Property(e => e.PbcHght).HasColumnName("pbc_hght");
            entity.Property(e => e.PbcHpos).HasColumnName("pbc_hpos");
            entity.Property(e => e.PbcInit)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbc_init");
            entity.Property(e => e.PbcJtfy).HasColumnName("pbc_jtfy");
            entity.Property(e => e.PbcLabl)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbc_labl");
            entity.Property(e => e.PbcLpos).HasColumnName("pbc_lpos");
            entity.Property(e => e.PbcMask)
                .HasMaxLength(31)
                .IsUnicode(false)
                .HasColumnName("pbc_mask");
            entity.Property(e => e.PbcOwnr)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("pbc_ownr");
            entity.Property(e => e.PbcPtrn)
                .HasMaxLength(31)
                .IsUnicode(false)
                .HasColumnName("pbc_ptrn");
            entity.Property(e => e.PbcTag)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbc_tag");
            entity.Property(e => e.PbcTid).HasColumnName("pbc_tid");
            entity.Property(e => e.PbcTnam)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("pbc_tnam");
            entity.Property(e => e.PbcWdth).HasColumnName("pbc_wdth");
        });

        modelBuilder.Entity<Pbcatedt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pbcatedt");

            entity.HasIndex(e => new { e.PbeName, e.PbeSeqn }, "pbcate_x").IsUnique();

            entity.Property(e => e.PbeCntr).HasColumnName("pbe_cntr");
            entity.Property(e => e.PbeEdit)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbe_edit");
            entity.Property(e => e.PbeFlag).HasColumnName("pbe_flag");
            entity.Property(e => e.PbeName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pbe_name");
            entity.Property(e => e.PbeSeqn).HasColumnName("pbe_seqn");
            entity.Property(e => e.PbeType).HasColumnName("pbe_type");
            entity.Property(e => e.PbeWork)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("pbe_work");
        });

        modelBuilder.Entity<Pbcatfmt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pbcatfmt");

            entity.HasIndex(e => e.PbfName, "pbcatf_x").IsUnique();

            entity.Property(e => e.PbfCntr).HasColumnName("pbf_cntr");
            entity.Property(e => e.PbfFrmt)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbf_frmt");
            entity.Property(e => e.PbfName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pbf_name");
            entity.Property(e => e.PbfType).HasColumnName("pbf_type");
        });

        modelBuilder.Entity<Pbcattbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pbcattbl");

            entity.HasIndex(e => new { e.PbtTnam, e.PbtOwnr }, "pbcatt_x").IsUnique();

            entity.Property(e => e.PbdFchr).HasColumnName("pbd_fchr");
            entity.Property(e => e.PbdFfce)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("pbd_ffce");
            entity.Property(e => e.PbdFhgt).HasColumnName("pbd_fhgt");
            entity.Property(e => e.PbdFitl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("pbd_fitl");
            entity.Property(e => e.PbdFptc).HasColumnName("pbd_fptc");
            entity.Property(e => e.PbdFunl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("pbd_funl");
            entity.Property(e => e.PbdFwgt).HasColumnName("pbd_fwgt");
            entity.Property(e => e.PbhFchr).HasColumnName("pbh_fchr");
            entity.Property(e => e.PbhFfce)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("pbh_ffce");
            entity.Property(e => e.PbhFhgt).HasColumnName("pbh_fhgt");
            entity.Property(e => e.PbhFitl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("pbh_fitl");
            entity.Property(e => e.PbhFptc).HasColumnName("pbh_fptc");
            entity.Property(e => e.PbhFunl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("pbh_funl");
            entity.Property(e => e.PbhFwgt).HasColumnName("pbh_fwgt");
            entity.Property(e => e.PblFchr).HasColumnName("pbl_fchr");
            entity.Property(e => e.PblFfce)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("pbl_ffce");
            entity.Property(e => e.PblFhgt).HasColumnName("pbl_fhgt");
            entity.Property(e => e.PblFitl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("pbl_fitl");
            entity.Property(e => e.PblFptc).HasColumnName("pbl_fptc");
            entity.Property(e => e.PblFunl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("pbl_funl");
            entity.Property(e => e.PblFwgt).HasColumnName("pbl_fwgt");
            entity.Property(e => e.PbtCmnt)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbt_cmnt");
            entity.Property(e => e.PbtOwnr)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("pbt_ownr");
            entity.Property(e => e.PbtTid).HasColumnName("pbt_tid");
            entity.Property(e => e.PbtTnam)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("pbt_tnam");
        });

        modelBuilder.Entity<Pbcatvld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pbcatvld");

            entity.HasIndex(e => e.PbvName, "pbcatv_x").IsUnique();

            entity.Property(e => e.PbvCntr).HasColumnName("pbv_cntr");
            entity.Property(e => e.PbvMsg)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbv_msg");
            entity.Property(e => e.PbvName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pbv_name");
            entity.Property(e => e.PbvType).HasColumnName("pbv_type");
            entity.Property(e => e.PbvVald)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("pbv_vald");
        });

        modelBuilder.Entity<Periodicidade>(entity =>
        {
            entity.HasKey(e => e.PeriodicidadId);

            entity.HasIndex(e => e.CodigoIes, "IX_Periodicidades").IsUnique();

            entity.Property(e => e.CodigoIes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Periodo>(entity =>
        {
            entity.ToTable("Periodo");

            entity.Property(e => e.AnoCohorte)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Campo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComputedColumnSql("([AnoCohorte]+[SemestreCohorte])", false);
            entity.Property(e => e.SemestreCohorte)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.PersonaId).HasName("PK_Personas_1");

            entity.Property(e => e.ApellidosNombresCompleto)
                .HasMaxLength(404)
                .HasComputedColumnSql("(((case when [PrimerApellido]<>'' then ''+ltrim(rtrim([PrimerApellido])) else '' end+case when [SegundoApellido]<>'' then ' '+ltrim(rtrim([SegundoApellido])) else '' end)+case when [PrimerNombre]<>'' then ' '+ltrim(rtrim([PrimerNombre])) else '' end)+case when [SegundoNombre]<>'' then ' '+ltrim(rtrim([SegundoNombre])) else '' end)", false);
            entity.Property(e => e.BarrioCodigo).HasMaxLength(200);
            entity.Property(e => e.CambiarContrasena).HasDefaultValue(true, "DF_Personas_CambiarContrasena");
            entity.Property(e => e.Celular).HasMaxLength(300);
            entity.Property(e => e.CorreoElectronico).HasMaxLength(300);
            entity.Property(e => e.CorreoInstitucional).HasMaxLength(150);
            entity.Property(e => e.DepartamentoBarrioCodigo).HasMaxLength(100);
            entity.Property(e => e.DepartamentoExpedicionCodigo).HasMaxLength(100);
            entity.Property(e => e.DepartamentoNacimientoCodigo).HasMaxLength(100);
            entity.Property(e => e.Direccion).HasMaxLength(400);
            entity.Property(e => e.EpsCodigo).HasMaxLength(100);
            entity.Property(e => e.EstadoCivil)
                .HasMaxLength(300)
                .HasComment("'C' 'CASADO(A)' \r\n'V' 'VIUDO(A)'\r\n'E' 'SEPARADO(A)'\r\n'D' 'DIVORCIADO(A)'\r\n'U' 'UNION LIBRE'\r\n'I' 'INDETERMINADO'\r\n'R' 'RELIGIOSO(A)' \r\n'M' 'MADRE SOLTERA'");
            entity.Property(e => e.Estrato).HasMaxLength(300);
            entity.Property(e => e.FechaIngreso).HasColumnType("datetime");
            entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");
            entity.Property(e => e.Genero).HasMaxLength(300);
            entity.Property(e => e.Identificacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdentificacionAnterior).HasMaxLength(50);
            entity.Property(e => e.IdentificacionAnteriorNoTomarSnies).HasColumnName("IdentificacionAnteriorNoTomarSNIES");
            entity.Property(e => e.MunicipioBarrioCodigo).HasMaxLength(150);
            entity.Property(e => e.MunicipioExpedicionCodigo).HasMaxLength(150);
            entity.Property(e => e.MunicipioNacimientoCodigo).HasMaxLength(150);
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(404)
                .HasComputedColumnSql("(((case when [PrimerNombre]<>'' then ''+ltrim(rtrim([PrimerNombre])) else '' end+case when [SegundoNombre]<>'' then ' '+ltrim(rtrim([SegundoNombre])) else '' end)+case when [PrimerApellido]<>'' then ' '+ltrim(rtrim([PrimerApellido])) else '' end)+case when [SegundoApellido]<>'' then ' '+ltrim(rtrim([SegundoApellido])) else '' end)", true);
            entity.Property(e => e.NumeroHijos).HasMaxLength(300);
            entity.Property(e => e.Observaciones).HasMaxLength(100);
            entity.Property(e => e.Ocupacion).HasMaxLength(100);
            entity.Property(e => e.PaisBarrioCodigo).HasMaxLength(100);
            entity.Property(e => e.PaisExpedicionCodigo).HasMaxLength(100);
            entity.Property(e => e.PaisNacimientoCodigo).HasMaxLength(100);
            entity.Property(e => e.PrimerApellido).HasMaxLength(100);
            entity.Property(e => e.PrimerNombre).HasMaxLength(100);
            entity.Property(e => e.Rh)
                .HasMaxLength(300)
                .HasColumnName("RH");
            entity.Property(e => e.SegundoApellido).HasMaxLength(100);
            entity.Property(e => e.SegundoNombre).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(300);
            entity.Property(e => e.Telefono2).HasMaxLength(300);
            entity.Property(e => e.TipoIdentificacionCodigo).HasMaxLength(100);
            entity.Property(e => e.TipoIdentificacionCodigoAnterior).HasMaxLength(100);
            entity.Property(e => e.TratamientoDatosFecha).HasColumnType("datetime");
            entity.Property(e => e.Usuario)
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.HasOne(d => d.Entidad).WithMany(p => p.Personas)
                .HasForeignKey(d => d.EntidadId)
                .HasConstraintName("FK_Personas_Entidades");

            entity.HasOne(d => d.NivelEducacion).WithMany(p => p.Personas)
                .HasForeignKey(d => d.NivelEducacionId)
                .HasConstraintName("FK_Personas_NivelesEducacion");
        });

        modelBuilder.Entity<PersonasCaracterizacion>(entity =>
        {
            entity.HasKey(e => e.PersonaCaracterizacionId).HasName("PK_PersonasCaracterizacion_1");

            entity.ToTable("PersonasCaracterizacion");

            entity.Property(e => e.ApellidosNombresCompleto)
                .HasMaxLength(404)
                .HasComputedColumnSql("(((case when [PrimerApellido]<>'' then ''+ltrim(rtrim([PrimerApellido])) else '' end+case when [SegundoApellido]<>'' then ' '+ltrim(rtrim([SegundoApellido])) else '' end)+case when [PrimerNombre]<>'' then ' '+ltrim(rtrim([PrimerNombre])) else '' end)+case when [SegundoNombre]<>'' then ' '+ltrim(rtrim([SegundoNombre])) else '' end)", false);
            entity.Property(e => e.BarrioCodigo).HasMaxLength(200);
            entity.Property(e => e.Celular).HasMaxLength(20);
            entity.Property(e => e.CorreoElectronico).HasMaxLength(300);
            entity.Property(e => e.CorreoInstitucional).HasMaxLength(150);
            entity.Property(e => e.DepartamentoBarrioCodigo).HasMaxLength(100);
            entity.Property(e => e.DepartamentoBarrioPrevioCodigo).HasMaxLength(100);
            entity.Property(e => e.DepartamentoExpedicionCodigo).HasMaxLength(100);
            entity.Property(e => e.DepartamentoNacimientoCodigo).HasMaxLength(100);
            entity.Property(e => e.Direccion).HasMaxLength(400);
            entity.Property(e => e.EpsCodigo).HasMaxLength(20);
            entity.Property(e => e.EstadoCivil).HasMaxLength(50);
            entity.Property(e => e.Estrato).HasMaxLength(20);
            entity.Property(e => e.FechaIngreso).HasColumnType("datetime");
            entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");
            entity.Property(e => e.FechaPresentacion).HasColumnType("datetime");
            entity.Property(e => e.Genero).HasMaxLength(20);
            entity.Property(e => e.Identificacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Jornada).HasMaxLength(80);
            entity.Property(e => e.MunicipioBarrioCodigo).HasMaxLength(150);
            entity.Property(e => e.MunicipioBarrioPrevioCodigo).HasMaxLength(100);
            entity.Property(e => e.MunicipioExpedicionCodigo).HasMaxLength(150);
            entity.Property(e => e.MunicipioNacimientoCodigo).HasMaxLength(150);
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(404)
                .HasComputedColumnSql("(((case when [PrimerNombre]<>'' then ''+ltrim(rtrim([PrimerNombre])) else '' end+case when [SegundoNombre]<>'' then ' '+ltrim(rtrim([SegundoNombre])) else '' end)+case when [PrimerApellido]<>'' then ' '+ltrim(rtrim([PrimerApellido])) else '' end)+case when [SegundoApellido]<>'' then ' '+ltrim(rtrim([SegundoApellido])) else '' end)", true);
            entity.Property(e => e.NumeroHijos).HasMaxLength(10);
            entity.Property(e => e.NumeroPersonasAcargo).HasMaxLength(10);
            entity.Property(e => e.Observaciones).HasMaxLength(100);
            entity.Property(e => e.Ocupacion).HasMaxLength(100);
            entity.Property(e => e.PaisBarrioCodigo).HasMaxLength(100);
            entity.Property(e => e.PaisBarrioPrevioCodigo).HasMaxLength(100);
            entity.Property(e => e.PaisExpedicionCodigo).HasMaxLength(100);
            entity.Property(e => e.PaisNacimientoCodigo).HasMaxLength(100);
            entity.Property(e => e.PrimerApellido).HasMaxLength(100);
            entity.Property(e => e.PrimerNombre).HasMaxLength(100);
            entity.Property(e => e.Programa).HasMaxLength(80);
            entity.Property(e => e.Rh)
                .HasMaxLength(10)
                .HasColumnName("RH");
            entity.Property(e => e.SegundoApellido).HasMaxLength(100);
            entity.Property(e => e.SegundoNombre).HasMaxLength(100);
            entity.Property(e => e.SemestreActual).HasMaxLength(10);
            entity.Property(e => e.Telefono).HasMaxLength(20);
            entity.Property(e => e.Telefono2).HasMaxLength(20);
            entity.Property(e => e.TipoIdentificacionCodigo).HasMaxLength(100);
            entity.Property(e => e.Usuario)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Version).HasMaxLength(50);
        });

        modelBuilder.Entity<PersonasCaracterizacionAdicional>(entity =>
        {
            entity.HasKey(e => e.PersonaCaracterizacionAdicionalId);

            entity.ToTable("PersonasCaracterizacionAdicional");

            entity.Property(e => e.ActividadEconomica).HasMaxLength(200);
            entity.Property(e => e.Afrodescendiente).HasMaxLength(80);
            entity.Property(e => e.ApoyoSocioEconomicoUniversitario).HasMaxLength(200);
            entity.Property(e => e.AreaFormacionContinuariaEstudios).HasMaxLength(200);
            entity.Property(e => e.ContinuariaEstudiosPosgrado).HasMaxLength(200);
            entity.Property(e => e.Discapacidad).HasMaxLength(200);
            entity.Property(e => e.ExposicionEvento).HasMaxLength(200);
            entity.Property(e => e.GastosAdicionalesCubrimiento).HasMaxLength(200);
            entity.Property(e => e.GastosDinero).HasMaxLength(200);
            entity.Property(e => e.GradoSatisfaccion).HasMaxLength(200);
            entity.Property(e => e.GrupoEtnicoResguardo).HasMaxLength(200);
            entity.Property(e => e.GrupoMinoritario).HasMaxLength(200);
            entity.Property(e => e.Indigena).HasMaxLength(80);
            entity.Property(e => e.IngresosHogar).HasMaxLength(200);
            entity.Property(e => e.InterrupcionAcademica).HasMaxLength(200);
            entity.Property(e => e.MedioTransporte).HasMaxLength(200);
            entity.Property(e => e.MotivoCarrera).HasMaxLength(200);
            entity.Property(e => e.NivelAdaptacion).HasMaxLength(200);
            entity.Property(e => e.NivelFormacionAcademica).HasMaxLength(200);
            entity.Property(e => e.OtraCualViviendaTipo).HasMaxLength(200);
            entity.Property(e => e.OtroCualApoyoSocioEconomicoUniversitario).HasMaxLength(200);
            entity.Property(e => e.OtroCualExposicionEvento).HasMaxLength(200);
            entity.Property(e => e.OtroCualGastosAdicionalesCubrimiento).HasMaxLength(200);
            entity.Property(e => e.OtroCualGrupoMinoritario).HasMaxLength(200);
            entity.Property(e => e.OtroCualInterrupcionAcademica).HasMaxLength(200);
            entity.Property(e => e.OtroCualMedioTransporte).HasMaxLength(200);
            entity.Property(e => e.OtroCualMotivoCarrera).HasMaxLength(200);
            entity.Property(e => e.OtroCualNivelAdaptacion).HasMaxLength(200);
            entity.Property(e => e.OtroCualOtrosEstudios).HasMaxLength(200);
            entity.Property(e => e.OtroCualPagoEstudios).HasMaxLength(200);
            entity.Property(e => e.OtroCualPorqueUniversidad).HasMaxLength(200);
            entity.Property(e => e.OtrosEstudios).HasMaxLength(200);
            entity.Property(e => e.PagoEstudios).HasMaxLength(200);
            entity.Property(e => e.PermanenciaGrupo).HasMaxLength(200);
            entity.Property(e => e.PorqueContinuariaEstudiosPosgrado).HasMaxLength(200);
            entity.Property(e => e.PorqueUniversidad).HasMaxLength(200);
            entity.Property(e => e.TiempoTraslado).HasMaxLength(200);
            entity.Property(e => e.UbicacionGrupoEtnicoResguardo).HasMaxLength(200);
            entity.Property(e => e.ViviendaTipo).HasMaxLength(200);

            entity.HasOne(d => d.PersonaCaracterizacion).WithMany(p => p.PersonasCaracterizacionAdicionals)
                .HasForeignKey(d => d.PersonaCaracterizacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PersonasCaracterizacionAdicional_PersonasCaracterizacion");
        });

        modelBuilder.Entity<PersonasCrm>(entity =>
        {
            entity.HasKey(e => e.PersonaId).HasName("PK_Personas");

            entity.ToTable("Personas_CRM");

            entity.Property(e => e.Barrio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Eps)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EPS");
            entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(203)
                .IsUnicode(false)
                .HasComputedColumnSql("(((([PrimerNombre]+' ')+isnull([SegundoNombre]+' ',''))+isnull([PrimerApellido]+' ',''))+isnull([SegundoApellido],''))", true);
            entity.Property(e => e.PrimerApellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrimerNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Rh)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("RH");
            entity.Property(e => e.SegundoApellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SegundoNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Telefono2)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TelefonoCelular)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TipoPersona)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.EstadoCivil).WithMany(p => p.PersonasCrms)
                .HasForeignKey(d => d.EstadoCivilId)
                .HasConstraintName("FK_Personas_EstadosCiviles");

            entity.HasOne(d => d.Genero).WithMany(p => p.PersonasCrms)
                .HasForeignKey(d => d.GeneroId)
                .HasConstraintName("FK_Personas_Generos");

            entity.HasOne(d => d.LugarNacimiento).WithMany(p => p.PersonasCrms)
                .HasForeignKey(d => d.LugarNacimientoId)
                .HasConstraintName("FK_Personas_Municipios");

            entity.HasOne(d => d.TipoIdentificacion).WithMany(p => p.PersonasCrms)
                .HasForeignKey(d => d.TipoIdentificacionId)
                .HasConstraintName("FK_Personas_TipoIdentificacion");
        });

        modelBuilder.Entity<PersonasOtrosDato>(entity =>
        {
            entity.HasKey(e => e.PersonaOtrosDatosId);

            entity.Property(e => e.EncuestaVirtualizacionFecha).HasColumnType("datetime");

            entity.HasOne(d => d.Persona).WithMany(p => p.PersonasOtrosDatos)
                .HasForeignKey(d => d.PersonaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PersonasOtrosDatos_Personas");
        });

        modelBuilder.Entity<PersonasxRequisitosxProceso>(entity =>
        {
            entity.ToTable("PersonasxRequisitosxProceso", tb =>
                {
                    tb.HasComment("Requisitos asociados al proceso en el que se encuentra la persona");
                    tb.HasTrigger("UpdatePersonasxRequisitosxProceso");
                });

            entity.Property(e => e.PersonasxRequisitosxProcesoId).HasComment("Consecutivo generado por el sistema");
            entity.Property(e => e.Anexo)
                .HasMaxLength(600)
                .IsUnicode(false);
            entity.Property(e => e.EstadoId).HasComment("Estado de cumplimiento del requisito:02- Completado, 03-Aplazado, 01-Pendiente");
            entity.Property(e => e.FechaCompromiso)
                .HasComment("Fecha de compromiso en la que se completará el requisito")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaCumplimiento)
                .HasComment("Fecha en la que se completa el requisito")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");
            entity.Property(e => e.FechaVigenciaRequisito)
                .HasComment("Fecha en la que se vence el requisito")
                .HasColumnType("datetime");
            entity.Property(e => e.InscripcionId).HasComment("Consecutivo que identifica la persona");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(600)
                .IsUnicode(false)
                .HasComment("Comentarios ingresados cuando se otorgan conseciones especiales para completar el requisito");
            entity.Property(e => e.RequisitosxProcesoId).HasComment("Consecutivo que identifica los requisitos del proceso en el que está asociada la persona");
            entity.Property(e => e.Usuario).HasMaxLength(300);

            entity.HasOne(d => d.Estado).WithMany(p => p.PersonasxRequisitosxProcesos)
                .HasForeignKey(d => d.EstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PersonasxRequisitosxProceso_Estados");

            entity.HasOne(d => d.Inscripcion).WithMany(p => p.PersonasxRequisitosxProcesos)
                .HasForeignKey(d => d.InscripcionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PersonasxRequisitosxProceso_Inscripciones");

            entity.HasOne(d => d.Periodo).WithMany(p => p.PersonasxRequisitosxProcesos)
                .HasForeignKey(d => d.PeriodoId)
                .HasConstraintName("FK_PersonasxRequisitosxProceso_Periodo");

            entity.HasOne(d => d.RequisitosxProceso).WithMany(p => p.PersonasxRequisitosxProcesos)
                .HasForeignKey(d => d.RequisitosxProcesoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PersonasxRequisitosxProceso_RequisitosxProceso");
        });

        modelBuilder.Entity<PersonasxTiposPersona>(entity =>
        {
            entity.HasKey(e => e.PersonaTipoPersonaId);

            entity.HasOne(d => d.Persona).WithMany(p => p.PersonasxTiposPersonas)
                .HasForeignKey(d => d.PersonaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PersonasxTiposPersonas_Personas");

            entity.HasOne(d => d.TiposPersona).WithMany(p => p.PersonasxTiposPersonas)
                .HasForeignKey(d => d.TiposPersonaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PersonasxTiposPersonas_TiposPersonas");
        });

        modelBuilder.Entity<PlanesAccion>(entity =>
        {
            entity.HasKey(e => e.PlanAccionId).HasName("PK_PlanAccion");

            entity.ToTable("PlanesAccion");

            entity.Property(e => e.Abril).HasDefaultValue(false);
            entity.Property(e => e.Agosto).HasDefaultValue(false);
            entity.Property(e => e.Diciembre).HasDefaultValue(false);
            entity.Property(e => e.Enero).HasDefaultValue(false);
            entity.Property(e => e.Febrero).HasDefaultValue(false);
            entity.Property(e => e.Julio).HasDefaultValue(false);
            entity.Property(e => e.Junio).HasDefaultValue(false);
            entity.Property(e => e.Marzo).HasDefaultValue(false);
            entity.Property(e => e.Mayo).HasDefaultValue(false);
            entity.Property(e => e.Noviembre).HasDefaultValue(false);
            entity.Property(e => e.Octubre).HasDefaultValue(false);
            entity.Property(e => e.Septiembre).HasDefaultValue(false);

            entity.HasOne(d => d.PlanDesarrollo).WithMany(p => p.PlanesAccions)
                .HasForeignKey(d => d.PlanDesarrolloId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PlanAccion_PlanDesarrollo");

            entity.HasOne(d => d.PlanDesarrolloItem).WithMany(p => p.PlanesAccions)
                .HasForeignKey(d => d.PlanDesarrolloItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PlanAccion_Item");

            entity.HasOne(d => d.UnidadOrganizacional).WithMany(p => p.PlanesAccions)
                .HasForeignKey(d => d.UnidadOrganizacionalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PlanAccion_Dependencia");
        });

        modelBuilder.Entity<PlanesDesarrollo>(entity =>
        {
            entity.HasKey(e => e.PlanDesarrolloId).HasName("PK_PlanDesarrollo");

            entity.ToTable("PlanesDesarrollo");

            entity.Property(e => e.Titulo).HasMaxLength(100);

            entity.HasOne(d => d.EntidadEducacion).WithMany(p => p.PlanesDesarrollos)
                .HasForeignKey(d => d.EntidadEducacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PlanDesarrollo_EntidadEducacion");
        });

        modelBuilder.Entity<PlanesDesarrolloItem>(entity =>
        {
            entity.HasKey(e => e.PlanDesarrolloItemId).HasName("PK_Item");

            entity.ToTable("PlanesDesarrolloItem");

            entity.Property(e => e.Numero).HasMaxLength(10);

            entity.HasOne(d => d.PlanDesarrollo).WithMany(p => p.PlanesDesarrolloItems)
                .HasForeignKey(d => d.PlanDesarrolloId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Item_PlanDesarrollo");

            entity.HasOne(d => d.PlanDesarrolloJerarquia).WithMany(p => p.PlanesDesarrolloItems)
                .HasForeignKey(d => d.PlanDesarrolloJerarquiaId)
                .HasConstraintName("FK_Item_Jerarquia");
        });

        modelBuilder.Entity<PlanesDesarrolloJerarquia>(entity =>
        {
            entity.HasKey(e => e.PlanDesarrolloJerarquiaId).HasName("PK_Jerarquia");

            entity.Property(e => e.Jerarquia).HasMaxLength(50);
        });

        modelBuilder.Entity<PlanesEstudio>(entity =>
        {
            entity.HasKey(e => e.PlanEstudioId);

            entity.ToTable("PlanesEstudio");

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Inactivo", "DF_PlanesEstudio_Estado");
            entity.Property(e => e.FechaVigencia).HasColumnType("datetime");
            entity.Property(e => e.UrlPlanEstudios)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Programa).WithMany(p => p.PlanesEstudios)
                .HasForeignKey(d => d.ProgramaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PlanesEstudio_Programas");
        });

        modelBuilder.Entity<PlanesEstudiosxInscripcion>(entity =>
        {
            entity.HasKey(e => e.PlanEstudioXestudianteId).HasName("PK_PlanesEstudiosXEstudiantes");

            entity.ToTable("PlanesEstudiosxInscripcion");

            entity.HasIndex(e => new { e.InscripcionId, e.PlanEstudioId }, "PlanesEstudiosxInscripcionNonClustered");

            entity.Property(e => e.PlanEstudioXestudianteId).HasColumnName("PlanEstudioXEstudianteId");
            entity.Property(e => e.FechaPlanEstudioInscripcion).HasColumnType("datetime");

            entity.HasOne(d => d.Inscripcion).WithMany(p => p.PlanesEstudiosxInscripcions)
                .HasForeignKey(d => d.InscripcionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PlanesEstudiosxInscripcion_Inscripciones");

            entity.HasOne(d => d.PlanEstudio).WithMany(p => p.PlanesEstudiosxInscripcions)
                .HasForeignKey(d => d.PlanEstudioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PlanesEstudiosXEstudiantes_PlanesEstudio");
        });

        modelBuilder.Entity<Pregunta>(entity =>
        {
            entity.Property(e => e.Descripcion).HasMaxLength(500);
            entity.Property(e => e.Nombre).HasMaxLength(400);
            entity.Property(e => e.Peso).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.TipoPregunta).HasMaxLength(50);

            entity.HasOne(d => d.Criterio).WithMany(p => p.Pregunta)
                .HasForeignKey(d => d.CriterioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Preguntas_Criterios");
        });

        modelBuilder.Entity<PreguntasxEvaluacion>(entity =>
        {
            entity.HasKey(e => e.PreguntaEvaluacionId).HasName("PK_CriteriosxEvaluacion");

            entity.ToTable("PreguntasxEvaluacion");

            entity.HasOne(d => d.Escala).WithMany(p => p.PreguntasxEvaluacions)
                .HasForeignKey(d => d.EscalaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PreguntasxEvaluacion_EscalaResultados");

            entity.HasOne(d => d.EvaluacionDocente).WithMany(p => p.PreguntasxEvaluacions)
                .HasForeignKey(d => d.EvaluacionDocenteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CriteriosxEvaluacion_EvaluacionDocente");
        });

        modelBuilder.Entity<Proceso>(entity =>
        {
            entity.ToTable("Proceso", tb => tb.HasComment("Almacena información de los procesos universitarios]"));

            entity.Property(e => e.ProcesoId).HasComment("Código de identificación del proceso");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasComment("Nombre con el que se describe el proceso");
        });

        modelBuilder.Entity<Programa>(entity =>
        {
            entity.Property(e => e.ActoAdministrativo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CicloPropedeutico).HasComment("01-SI 02-NO");
            entity.Property(e => e.CodigoNivelSuperior)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoProgramaIes)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CodigoProgramaIES");
            entity.Property(e => e.EntidadAcreditacionInternacional)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaAcreditacion).HasColumnType("datetime");
            entity.Property(e => e.FechaAcreditacionInternacional).HasColumnType("datetime");
            entity.Property(e => e.Metodologia)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("01-presencial 02-Distancia");
            entity.Property(e => e.Nbcid).HasColumnName("NBCId");
            entity.Property(e => e.NivelPrograma).HasComment("01-pregrado 02-posgrado");
            entity.Property(e => e.NombrePrograma)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Titulo)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.UrlInformacionPrograma)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UrlPerfilAspirante)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UrlPerfilProfesionalPrograma)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.AreaConocimiento).WithMany(p => p.Programas)
                .HasForeignKey(d => d.AreaConocimientoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Programas_AreasNBC");

            entity.HasOne(d => d.EstadoPrograma).WithMany(p => p.Programas)
                .HasForeignKey(d => d.EstadoProgramaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Programas_EstadosProgramas");

            entity.HasOne(d => d.Justificacion).WithMany(p => p.Programas)
                .HasForeignKey(d => d.JustificacionId)
                .HasConstraintName("FK_Programas_Justificaciones");

            entity.HasOne(d => d.Modalidad).WithMany(p => p.Programas)
                .HasForeignKey(d => d.ModalidadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Programas_Modalidades");

            entity.HasOne(d => d.Nbc).WithMany(p => p.Programas)
                .HasForeignKey(d => d.Nbcid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Programas_NBC");

            entity.HasOne(d => d.Periodicidad).WithMany(p => p.Programas)
                .HasForeignKey(d => d.PeriodicidadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Programas_Periodicidades");

            entity.HasOne(d => d.TipoAcreditacion).WithMany(p => p.Programas)
                .HasForeignKey(d => d.TipoAcreditacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Programas_TipoAcreditacion");

            entity.HasOne(d => d.UnidadOrganizacional).WithMany(p => p.Programas)
                .HasForeignKey(d => d.UnidadOrganizacionalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Programas_UnidadOrganizacional");
        });

        modelBuilder.Entity<ProgramacionEvaluacion>(entity =>
        {
            entity.HasKey(e => e.SeguimientoId).HasName("PK_ProgramacionSeguimientos");

            entity.ToTable("ProgramacionEvaluacion");

            entity.Property(e => e.CriterioEvaluacion).HasMaxLength(150);
            entity.Property(e => e.Evidencia).HasMaxLength(300);
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaEvaluacion).HasColumnType("datetime");
            entity.Property(e => e.Instrumento).HasMaxLength(100);
            entity.Property(e => e.Observaciones).HasMaxLength(500);
            entity.Property(e => e.PorcentajeEvaluacion).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.Usuario).HasMaxLength(150);

            entity.HasOne(d => d.Grupo).WithMany(p => p.ProgramacionEvaluacions)
                .HasForeignKey(d => d.GrupoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProgramacionEvaluacion_Grupos");

            entity.HasOne(d => d.Periodo).WithMany(p => p.ProgramacionEvaluacions)
                .HasForeignKey(d => d.PeriodoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProgramacionEvaluacion_Periodo");

            entity.HasOne(d => d.TipoEvaluacion).WithMany(p => p.ProgramacionEvaluacions)
                .HasForeignKey(d => d.TipoEvaluacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProgramacionSeguimientos_TipoEvaluacion");
        });

        modelBuilder.Entity<ProgramasxProgramasCrm>(entity =>
        {
            entity.HasKey(e => e.ProgramaCrmprogramaId);

            entity.ToTable("ProgramasxProgramasCRM");

            entity.Property(e => e.ProgramaCrmprogramaId).HasColumnName("ProgramaCRMProgramaId");
            entity.Property(e => e.ProgramaCrm)
                .HasMaxLength(550)
                .HasColumnName("ProgramaCRM");

            entity.HasOne(d => d.Programa).WithMany(p => p.ProgramasxProgramasCrms)
                .HasForeignKey(d => d.ProgramaId)
                .HasConstraintName("FK_ProgramasxProgramasCRM_Programas");
        });

        modelBuilder.Entity<ProgramasxTiposJornada>(entity =>
        {
            entity.HasKey(e => e.ProgramaJornadaId);

            entity.HasOne(d => d.Jornada).WithMany(p => p.ProgramasxTiposJornada)
                .HasForeignKey(d => d.JornadaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Programas_Jornadas_Jornadas");

            entity.HasOne(d => d.Programa).WithMany(p => p.ProgramasxTiposJornada)
                .HasForeignKey(d => d.ProgramaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Programas_Jornadas_Programas");
        });

        modelBuilder.Entity<RangosHermano>(entity =>
        {
            entity.HasIndex(e => e.CodigoIes, "IX_RangosHermanos").IsUnique();

            entity.Property(e => e.CodigoIes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RangosIngresosCrm>(entity =>
        {
            entity.HasKey(e => e.RangoIngresoId).HasName("PK_RangosIngresos");

            entity.ToTable("RangosIngresos_CRM");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Recaudo>(entity =>
        {
            entity.Property(e => e.Authorization)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaRecaudo).HasColumnType("datetime");
            entity.Property(e => e.FechaRequest).HasColumnType("datetime");
            entity.Property(e => e.FechaStatus).HasColumnType("datetime");
            entity.Property(e => e.Franchise)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Iesid).HasColumnName("IESId");
            entity.Property(e => e.InternalReference)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IssuerName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Message)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.NitFacturadora).HasMaxLength(20);
            entity.Property(e => e.NombreArchivo)
                .HasMaxLength(600)
                .IsUnicode(false);
            entity.Property(e => e.NumeroCuenta).HasMaxLength(20);
            entity.Property(e => e.PaymentFechaStatus).HasColumnType("datetime");
            entity.Property(e => e.PaymentMessage)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PaymentMethodName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PaymentReason)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcessUrl)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("ProcessURL");
            entity.Property(e => e.ReasonStatus)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Receipt)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Reference)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RegistroControlLote).HasMaxLength(150);
            entity.Property(e => e.RegistroEncabezadoLote).HasMaxLength(150);
            entity.Property(e => e.RequestId).HasColumnName("RequestID");
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TipoCuenta).HasMaxLength(10);
            entity.Property(e => e.TipoRecaudoId).HasComment("1: Convenios (archivos planos) 2: Web - Pasarela");
            entity.Property(e => e.TipoRegistroControl).HasMaxLength(10);
            entity.Property(e => e.TipoRegistroEncabezado).HasMaxLength(10);
            entity.Property(e => e.TotalRegistrosLote).HasMaxLength(10);
            entity.Property(e => e.ValorTotalRecaudadoLote).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Banco).WithMany(p => p.Recaudos)
                .HasForeignKey(d => d.BancoId)
                .HasConstraintName("FK_Recaudos_Bancos");

            entity.HasOne(d => d.Ies).WithMany(p => p.Recaudos)
                .HasForeignKey(d => d.Iesid)
                .HasConstraintName("FK_Recaudos_IES");

            entity.HasOne(d => d.Periodo).WithMany(p => p.Recaudos)
                .HasForeignKey(d => d.PeriodoId)
                .HasConstraintName("FK_Recaudos_Periodo");
        });

        modelBuilder.Entity<RecaudosConfiguracione>(entity =>
        {
            entity.HasKey(e => e.RecaudoConfiguracionId).HasName("PK_RecaudosConfiguracionesxBancos");

            entity.Property(e => e.Descripcion).HasMaxLength(150);
            entity.Property(e => e.NombreRecaudoConfiguracionxBanco).HasMaxLength(50);
            entity.Property(e => e.Version)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.Banco).WithMany(p => p.RecaudosConfiguraciones)
                .HasForeignKey(d => d.BancoId)
                .HasConstraintName("FK_RecaudosConfiguracionesxBancos_Bancos");
        });

        modelBuilder.Entity<RecaudosConfiguracionesSeccione>(entity =>
        {
            entity.HasKey(e => e.RecaudoConfiguracionSeccionesId);

            entity.Property(e => e.CantidadLineas).HasComment("Si es desconocido se coloca en 0 (cero)");
            entity.Property(e => e.LineasSinImportancia)
                .HasMaxLength(50)
                .HasComment("Separados por , Ej: 2,5,6,7");
            entity.Property(e => e.NombreSeccion).HasMaxLength(50);

            entity.HasOne(d => d.RecaudoConfiguracion).WithMany(p => p.RecaudosConfiguracionesSecciones)
                .HasForeignKey(d => d.RecaudoConfiguracionId)
                .HasConstraintName("FK_RecaudosConfiguracionesSecciones_RecaudosConfiguracionesxBancos");
        });

        modelBuilder.Entity<RecaudosConfiguracionesSeccionesDetalle>(entity =>
        {
            entity.HasKey(e => e.RecaudoConfiguracionConfiguracionId).HasName("PK_RecaudosConfiguracionesDetallesId");

            entity.Property(e => e.Descripcion).HasMaxLength(80);
            entity.Property(e => e.EquivalenciaRecaudosCampos).HasMaxLength(100);
            entity.Property(e => e.Formato).HasMaxLength(50);
            entity.Property(e => e.NombreCampo).HasMaxLength(80);

            entity.HasOne(d => d.RecaudoConfiguracionSeccion).WithMany(p => p.RecaudosConfiguracionesSeccionesDetalles)
                .HasForeignKey(d => d.RecaudoConfiguracionSeccionId)
                .HasConstraintName("FK_RecaudosConfiguracionesDetallesId_RecaudosConfiguracionesxBancos");
        });

        modelBuilder.Entity<RecaudosConfiguracionesxEntidadesBancaria>(entity =>
        {
            entity.HasKey(e => e.RecaudoConfiguracionxBancoId).HasName("PK_RecaudosConfiguracionesxBancos_1");

            entity.HasOne(d => d.Banco).WithMany(p => p.RecaudosConfiguracionesxEntidadesBancaria)
                .HasForeignKey(d => d.BancoId)
                .HasConstraintName("FK_RecaudosConfiguracionesxBancos_Bancos1");

            entity.HasOne(d => d.RecaudoConfiguracion).WithMany(p => p.RecaudosConfiguracionesxEntidadesBancaria)
                .HasForeignKey(d => d.RecaudoConfiguracionId)
                .HasConstraintName("FK_RecaudosConfiguracionesxBancos_RecaudosConfiguraciones");
        });

        modelBuilder.Entity<RecaudosDetalle>(entity =>
        {
            entity.HasKey(e => e.RecaudoDetalleId).HasName("PK_DetallesRecaudos");

            entity.Property(e => e.CodigoSucursal).HasMaxLength(50);
            entity.Property(e => e.DatosAdicionales).HasMaxLength(200);
            entity.Property(e => e.ReferenciaUsuario).HasMaxLength(20);
            entity.Property(e => e.RegistroDetalle).HasMaxLength(150);
            entity.Property(e => e.Secuencia).HasMaxLength(20);
            entity.Property(e => e.TipoRegistroDetalle).HasMaxLength(20);
            entity.Property(e => e.ValorRecaudado).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Liquidacion).WithMany(p => p.RecaudosDetalles)
                .HasForeignKey(d => d.LiquidacionId)
                .HasConstraintName("FK_RecaudosDetalles_Liquidaciones");

            entity.HasOne(d => d.Recaudo).WithMany(p => p.RecaudosDetalles)
                .HasForeignKey(d => d.RecaudoId)
                .HasConstraintName("FK_RecaudosDetalles_Recaudos");
        });

        modelBuilder.Entity<RecursosFisico>(entity =>
        {
            entity.HasKey(e => e.RecursoFisicoId).HasName("PK_Aulas");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.TipoRecursoFisico).WithMany(p => p.RecursosFisicos)
                .HasForeignKey(d => d.TipoRecursoFisicoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecursosFisicos_TipoRecursoFisico");
        });

        modelBuilder.Entity<Requisito>(entity =>
        {
            entity.HasKey(e => e.RequisitoId).HasName("PK_Documentos");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RequisitosxProceso>(entity =>
        {
            entity.ToTable("RequisitosxProceso");

            entity.HasOne(d => d.Proceso).WithMany(p => p.RequisitosxProcesos)
                .HasForeignKey(d => d.ProcesoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RequisitosxProceso_Proceso");

            entity.HasOne(d => d.Requisito).WithMany(p => p.RequisitosxProcesos)
                .HasForeignKey(d => d.RequisitoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RequisitosxProceso_Requisitos");
        });

        modelBuilder.Entity<ResponsablexEntrevistum>(entity =>
        {
            entity.HasKey(e => e.ResponsableEntrevistaId).HasName("PK_ResponsablexEntrevista_1");

            entity.ToTable(tb => tb.HasComment("Almacena la información de los responsables de las entrevistas"));

            entity.Property(e => e.ResponsableEntrevistaId).HasComment("Consecutivo generado por el sistema");

            entity.HasOne(d => d.Entrevista).WithMany(p => p.ResponsablexEntrevista)
                .HasForeignKey(d => d.EntrevistaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ResponsablexEntrevista_Entrevistas");

            entity.HasOne(d => d.Persona).WithMany(p => p.ResponsablexEntrevista)
                .HasForeignKey(d => d.PersonaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ResponsablexEntrevista_Personas");
        });

        modelBuilder.Entity<ResultadosEvaluacione>(entity =>
        {
            entity.HasNoKey();

            entity.HasOne(d => d.EncabezadoResultados).WithMany()
                .HasForeignKey(d => d.EncabezadoResultadosId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ResultadosEvaluaciones_EncabezadoResultados");

            entity.HasOne(d => d.Escala).WithMany()
                .HasForeignKey(d => d.EscalaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ResultadosEvaluaciones_EscalaResultados1");

            entity.HasOne(d => d.PreguntaEvaluacion).WithMany()
                .HasForeignKey(d => d.PreguntaEvaluacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ResultadosEvaluaciones_PreguntasxEvaluacion");
        });

        modelBuilder.Entity<SolicitudesCancelacion>(entity =>
        {
            entity.HasKey(e => e.SolicitudCancelacionId);

            entity.ToTable("SolicitudesCancelacion");

            entity.Property(e => e.FechaAprobacion).HasColumnType("datetime");
            entity.Property(e => e.FechaAsentada).HasColumnType("datetime");
            entity.Property(e => e.FechaBienestar).HasColumnType("datetime");
            entity.Property(e => e.FechaGeneracion).HasColumnType("datetime");
            entity.Property(e => e.Observaciones).HasMaxLength(500);
            entity.Property(e => e.ObservacionesBienestar).HasMaxLength(500);
            entity.Property(e => e.TipoCancelacion).HasMaxLength(80);
            entity.Property(e => e.UsuarioAprobacion).HasMaxLength(150);
            entity.Property(e => e.UsuarioAsentada).HasMaxLength(500);
            entity.Property(e => e.UsuarioBienestar).HasMaxLength(150);
            entity.Property(e => e.UsuarioSolicitud).HasMaxLength(150);

            entity.HasOne(d => d.EstadoSolicitud).WithMany(p => p.SolicitudesCancelacions)
                .HasForeignKey(d => d.EstadoSolicitudId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SolicitudesCancelacion_Estados");

            entity.HasOne(d => d.Inscripcion).WithMany(p => p.SolicitudesCancelacions)
                .HasForeignKey(d => d.InscripcionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SolicitudesCancelacion_Inscripciones");

            entity.HasOne(d => d.Periodo).WithMany(p => p.SolicitudesCancelacions)
                .HasForeignKey(d => d.PeriodoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SolicitudesCancelacion_Periodo");
        });

        modelBuilder.Entity<SolicitudesCancelacionesDetalle>(entity =>
        {
            entity.HasKey(e => e.SolicitudCancelacionDetalleId).HasName("PK_DetalleSolicitudesCancelaciones");

            entity.HasOne(d => d.SolicitudCancelacion).WithMany(p => p.SolicitudesCancelacionesDetalles)
                .HasForeignKey(d => d.SolicitudCancelacionId)
                .HasConstraintName("FK_DetalleSolicitudesCancelaciones_DetalleSolicitudesCancelaciones");
        });

        modelBuilder.Entity<Suficiencia>(entity =>
        {
            entity.Property(e => e.FechaAsentamiento).HasColumnType("datetime");
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.Nota).HasColumnType("numeric(4, 2)");

            entity.HasOne(d => d.HistoricoNota).WithMany(p => p.Suficiencia)
                .HasForeignKey(d => d.HistoricoNotaId)
                .HasConstraintName("FK_Suficiencias_HistoricoNotas");

            entity.HasOne(d => d.Inscripcion).WithMany(p => p.Suficiencia)
                .HasForeignKey(d => d.InscripcionId)
                .HasConstraintName("FK_Suficiencias_Inscripciones");

            entity.HasOne(d => d.OcupacionRecursoFisico).WithMany(p => p.Suficiencia)
                .HasForeignKey(d => d.OcupacionRecursoFisicoId)
                .HasConstraintName("FK_Suficiencias_OcupacionxRecursoFisico");

            entity.HasOne(d => d.Periodo).WithMany(p => p.Suficiencia)
                .HasForeignKey(d => d.PeriodoId)
                .HasConstraintName("FK_Suficiencias_Periodo");

            entity.HasOne(d => d.Persona).WithMany(p => p.Suficiencia)
                .HasForeignKey(d => d.PersonaId)
                .HasConstraintName("FK_Suficiencias_Personas");

            entity.HasOne(d => d.PlanEstudioAsignatura).WithMany(p => p.Suficiencia)
                .HasForeignKey(d => d.PlanEstudioAsignaturaId)
                .HasConstraintName("FK_Suficiencias_AsignaturasxPlanesEstudios");

            entity.HasOne(d => d.PlanEstudio).WithMany(p => p.Suficiencia)
                .HasForeignKey(d => d.PlanEstudioId)
                .HasConstraintName("FK_Suficiencias_PlanesEstudio");

            entity.HasOne(d => d.RecursoFisico).WithMany(p => p.Suficiencia)
                .HasForeignKey(d => d.RecursoFisicoId)
                .HasConstraintName("FK_Suficiencias_RecursosFisicos");
        });

        modelBuilder.Entity<SuficienciasxInscripcione>(entity =>
        {
            entity.HasKey(e => e.SuficienciaInscripcionId);

            entity.Property(e => e.Nota).HasColumnType("numeric(4, 2)");

            entity.HasOne(d => d.Inscripcion).WithMany(p => p.SuficienciasxInscripciones)
                .HasForeignKey(d => d.InscripcionId)
                .HasConstraintName("FK_SuficienciasxInscripciones_Inscripciones");

            entity.HasOne(d => d.PlanEstudioAsignatura).WithMany(p => p.SuficienciasxInscripciones)
                .HasForeignKey(d => d.PlanEstudioAsignaturaId)
                .HasConstraintName("FK_SuficienciasxInscripciones_AsignaturasxPlanesEstudios");

            entity.HasOne(d => d.Suficiencia).WithMany(p => p.SuficienciasxInscripciones)
                .HasForeignKey(d => d.SuficienciaId)
                .HasConstraintName("FK_SuficienciasxInscripciones_Suficiencias");
        });

        modelBuilder.Entity<TipoAcreditacion>(entity =>
        {
            entity.ToTable("TipoAcreditacion");

            entity.HasIndex(e => e.CodigoIes, "IX_TipoAcreditacion").IsUnique();

            entity.Property(e => e.CodigoIes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoAsignatura>(entity =>
        {
            entity.ToTable("TipoAsignatura");

            entity.HasIndex(e => e.CodigoIes, "IX_TipoAsignatura").IsUnique();

            entity.Property(e => e.CodigoIes)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoCubrimiento>(entity =>
        {
            entity.ToTable("TipoCubrimiento");

            entity.HasIndex(e => e.CodigoIes, "IX_TipoCubrimiento").IsUnique();

            entity.Property(e => e.CodigoIes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoEvaluacion>(entity =>
        {
            entity.ToTable("TipoEvaluacion");

            entity.Property(e => e.Descripcion).HasMaxLength(50);
            entity.Property(e => e.Iesid).HasColumnName("IESId");
            entity.Property(e => e.PorcentajeMaximoItem).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.PorcentajeMinimoItem).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.PorcentajeTipoEvaluacion).HasColumnType("numeric(5, 2)");

            entity.HasOne(d => d.Ies).WithMany(p => p.TipoEvaluacions)
                .HasForeignKey(d => d.Iesid)
                .HasConstraintName("FK_TipoEvaluacion_IES");

            entity.HasOne(d => d.Periodo).WithMany(p => p.TipoEvaluacions)
                .HasForeignKey(d => d.PeriodoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TipoEvaluacion_Periodo");

            entity.HasOne(d => d.Programa).WithMany(p => p.TipoEvaluacions)
                .HasForeignKey(d => d.ProgramaId)
                .HasConstraintName("FK_TipoEvaluacion_Programas");
        });

        modelBuilder.Entity<TipoIdentificacionCrm>(entity =>
        {
            entity.HasKey(e => e.TipoIdentificacionId).HasName("PK_TipoIdentificacion");

            entity.ToTable("TipoIdentificacion_CRM");

            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoNormaLegal>(entity =>
        {
            entity.ToTable("TipoNormaLegal");

            entity.HasIndex(e => e.CodigoIes, "IX_TipoNormaLegal").IsUnique();

            entity.Property(e => e.CodigoIes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoOcupacion>(entity =>
        {
            entity.ToTable("TipoOcupacion");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoOcupacionDocente>(entity =>
        {
            entity.ToTable("TipoOcupacionDocente");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoRecursoFisico>(entity =>
        {
            entity.ToTable("TipoRecursoFisico");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoReglamentoOpcional>(entity =>
        {
            entity.HasKey(e => e.TipoReglamentoId);

            entity.ToTable("TipoReglamentoOpcional");

            entity.HasIndex(e => e.CodigoIes, "IX_TipoReglamentoOpcional").IsUnique();

            entity.Property(e => e.CodigoIes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoUnidadOrganizacional>(entity =>
        {
            entity.ToTable("TipoUnidadOrganizacional", tb => tb.HasComment("Almacena las sedes, divisiones, áreas o unidades organizacionales pertenecientes a la IES, incluyendo convenios"));

            entity.HasIndex(e => e.CodigoIes, "IX_TipoUnidadOrganizacional").IsUnique();

            entity.Property(e => e.CodigoIes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TiposCalificacionTool>(entity =>
        {
            entity.HasKey(e => e.TipoCalificacionToolId);

            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<TiposCertificado>(entity =>
        {
            entity.HasKey(e => e.TipoCertificadoId);

            entity.Property(e => e.Descripcion).HasMaxLength(100);
        });

        modelBuilder.Entity<TiposDeuda>(entity =>
        {
            entity.HasKey(e => e.TipoDeudaId);

            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<TiposEstado>(entity =>
        {
            entity.HasKey(e => e.TipoEstadoId);

            entity.Property(e => e.Descripcion)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TiposGruposPlane>(entity =>
        {
            entity.HasKey(e => e.TipoGrupoPlanId);

            entity.Property(e => e.NombreTipoGrupoPlan).HasMaxLength(50);
        });

        modelBuilder.Entity<TiposIngreso>(entity =>
        {
            entity.HasKey(e => e.TipoIngresoId);

            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(80);
        });

        modelBuilder.Entity<TiposInscripcion>(entity =>
        {
            entity.HasKey(e => e.TipoInscripcionId).HasName("PK_TiposInscripción");

            entity.ToTable("TiposInscripcion");

            entity.HasIndex(e => e.CodigoIes, "IX_TiposInscripcion").IsUnique();

            entity.Property(e => e.CodigoIes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TiposJornada>(entity =>
        {
            entity.HasKey(e => e.JornadaId).HasName("PK_Jornadas");

            entity.HasIndex(e => e.CodigoIes, "IX_TiposJornadas").IsUnique();

            entity.Property(e => e.CodigoIes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TiposLiquidacion>(entity =>
        {
            entity.ToTable("TiposLiquidacion", tb => tb.HasComment("Almacena los diferentes conceptos usados para generar liquidaciones"));

            entity.HasIndex(e => e.CodigoIes, "IX_TiposLiquidacion").IsUnique();

            entity.Property(e => e.CodigoIes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fuente).HasMaxLength(50);
        });

        modelBuilder.Entity<TiposPago>(entity =>
        {
            entity.HasKey(e => e.TipoPagoId);

            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(80);
        });

        modelBuilder.Entity<TiposParentesco>(entity =>
        {
            entity.HasKey(e => e.ParentescoId);

            entity.ToTable("TiposParentesco");

            entity.HasIndex(e => e.CodigoIes, "IX_TiposParentesco").IsUnique();

            entity.Property(e => e.CodigoIes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TiposPersona>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TiposRelacion>(entity =>
        {
            entity.ToTable("TiposRelacion");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TiposTrabajo>(entity =>
        {
            entity.HasKey(e => e.TipoTrabajoId);

            entity.HasIndex(e => e.CodigoIes, "IX_TiposTrabajos").IsUnique();

            entity.Property(e => e.CodigoIes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoIES");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UnidadOrganizacional>(entity =>
        {
            entity.HasKey(e => e.UnidadOrganizacionalId).HasName("PK_UnidadOrganizacional_1");

            entity.ToTable("UnidadOrganizacional");

            entity.HasIndex(e => e.CodigoUnidadOrgIes, "IX_UnidadOrganizacional").IsUnique();

            entity.Property(e => e.CodigoUnidadOrgIes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CodigoUnidadOrgIES");
            entity.Property(e => e.DepartamentoId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Extension)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MunicipioId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreUnidad)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.PaisId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.EntidadEducacion).WithMany(p => p.UnidadOrganizacionals)
                .HasForeignKey(d => d.EntidadEducacionId)
                .HasConstraintName("FK_UnidadOrganizacional_IES1");

            entity.HasOne(d => d.Persona).WithMany(p => p.UnidadOrganizacionals)
                .HasForeignKey(d => d.PersonaId)
                .HasConstraintName("FK_UnidadOrganizacional_Personas");

            entity.HasOne(d => d.TipoUnidadOrganizacional).WithMany(p => p.UnidadOrganizacionals)
                .HasForeignKey(d => d.TipoUnidadOrganizacionalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UnidadOrganizacional_TipoUnidadOrganizacional");
        });

        modelBuilder.Entity<VObjetosBd>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_objetos_bd");

            entity.Property(e => e.CTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("c_tipo");
            entity.Property(e => e.SNombre)
                .HasMaxLength(128)
                .HasColumnName("s_nombre");
            entity.Property(e => e.STabla)
                .HasMaxLength(128)
                .HasColumnName("s_tabla");
            entity.Property(e => e.SUsuario)
                .HasMaxLength(128)
                .HasColumnName("s_usuario");
        });

        modelBuilder.Entity<ViewAsignaturasxPlanEstudio>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewAsignaturasxPlanEstudios");

            entity.Property(e => e.DescripcionEstadoAsignatura).HasMaxLength(50);
            entity.Property(e => e.EstadoPlanesEstudio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EstadosAsigxPlanEstudios)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaVigencia).HasColumnType("datetime");
            entity.Property(e => e.NombreAsignatura)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewDocenteProgramacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewDocenteProgramacion");

            entity.Property(e => e.DescripcionGrupo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NombreAsignaturaGrupo)
                .HasMaxLength(209)
                .IsUnicode(false);
            entity.Property(e => e.NombrePrograma)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewEntrevistum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewEntrevista");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EstDescrip)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.FechaInicio)
                .HasMaxLength(92)
                .IsUnicode(false);
            entity.Property(e => e.HoraFin)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Hora_Fin");
            entity.Property(e => e.HoraInicio)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Hora_Inicio");
            entity.Property(e => e.IdenAspirante)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombrePrograma)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NombreUnidad)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewEstudiantesProgramacionEvaluacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewEstudiantesProgramacionEvaluacion");

            entity.Property(e => e.CriterioEvaluacion).HasMaxLength(100);
            entity.Property(e => e.DescripcionGrupo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EstudianteId).HasColumnName("estudianteId");
            entity.Property(e => e.Evidencia).HasMaxLength(100);
            entity.Property(e => e.FechaEvaluacion).HasColumnType("datetime");
            entity.Property(e => e.Instrumento).HasMaxLength(100);
            entity.Property(e => e.NombreAsignaturaGrupo)
                .HasMaxLength(209)
                .IsUnicode(false);
            entity.Property(e => e.NombrePeriodo)
                .HasMaxLength(21)
                .IsUnicode(false);
            entity.Property(e => e.NombrePrograma)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NombreTipoEvaluacion).HasMaxLength(50);
            entity.Property(e => e.Nota).HasColumnType("numeric(3, 2)");
            entity.Property(e => e.Observaciones).HasMaxLength(100);
            entity.Property(e => e.PorcentajeEvaluacion).HasColumnType("numeric(5, 2)");
        });

        modelBuilder.Entity<ViewJornadasByProgramaId>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewJornadasByProgramaId");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewNotasAlumno>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Notas_Alumnos");

            entity.Property(e => e.Descripcion).HasMaxLength(50);
            entity.Property(e => e.FechaEvaluacion).HasColumnType("datetime");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nota).HasColumnType("numeric(3, 2)");
            entity.Property(e => e.PorcentajeEvaluacion).HasColumnType("numeric(5, 2)");
        });

        modelBuilder.Entity<ViewPersona>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewPersonas");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Identificacion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewPersonasxTipoPersona>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewPersonasxTipoPersonas");

            entity.Property(e => e.AnoCohorte)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DescripEstado)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.DescripProceso)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.DescripRequisito)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DescripTipEstado)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.FechaCompromiso).HasColumnType("datetime");
            entity.Property(e => e.FechaCumplimiento).HasColumnType("datetime");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SemestreCohorte)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewProgramaByPersonaInscritum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewProgramaByPersonaInscrita");

            entity.Property(e => e.AnoCohorte)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Identificacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombrePrograma)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SemestreCohorte)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewProgramasByPersona>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ProgramasByPersonas");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Identificacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombrePrograma)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewResponsablexEntrevistaxFecha>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewResponsablexEntrevistaxFecha");

            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewResponsablexEntrevistum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewResponsablexEntrevista");

            entity.Property(e => e.AnoCohorte)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AreasApoyo).IsUnicode(false);
            entity.Property(e => e.Concepto).IsUnicode(false);
            entity.Property(e => e.ConocelaU).IsUnicode(false);
            entity.Property(e => e.DesHinformaticas)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DesHInformaticas");
            entity.Property(e => e.DesOtraOp).IsUnicode(false);
            entity.Property(e => e.DesSegundoIdioma)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionEstado)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionProceso)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionRequsito)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionTipoEstado)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.DesvAcademica)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaEntrevista).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.Hinformaticas).HasColumnName("HInformaticas");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdentificacionEnt)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Logros).IsUnicode(false);
            entity.Property(e => e.OtraInstitucion).IsUnicode(false);
            entity.Property(e => e.RazonesPgma).IsUnicode(false);
            entity.Property(e => e.RazonesU).IsUnicode(false);
            entity.Property(e => e.SemestreCohorte)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
