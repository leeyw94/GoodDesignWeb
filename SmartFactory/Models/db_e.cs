using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SmartFactory.Models
{
    public partial class db_e : DbContext
    {
        public db_e()
        {
        }

        public db_e(DbContextOptions<db_e> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Avoidance> Avoidance { get; set; }
        public virtual DbSet<BoardCode> BoardCode { get; set; }
        public virtual DbSet<BoardComment> BoardComment { get; set; }
        public virtual DbSet<BoardFile> BoardFile { get; set; }
        public virtual DbSet<BoardList> BoardList { get; set; }
        public virtual DbSet<BoardMenu> BoardMenu { get; set; }
        public virtual DbSet<BoardRread> BoardRread { get; set; }
        public virtual DbSet<CategoryMenus> CategoryMenus { get; set; }
        public virtual DbSet<Md_Image> Md_Image { get; set; }
        public virtual DbSet<New_work> New_work { get; set; }
        public virtual DbSet<Process> Process { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<QA> QA { get; set; }
        public virtual DbSet<cal_memo> cal_memo { get; set; }
        public virtual DbSet<calendar> calendar { get; set; }
        public virtual DbSet<code_1> code_1 { get; set; }
        public virtual DbSet<code_auth> code_auth { get; set; }
        public virtual DbSet<code_auth_ex> code_auth_ex { get; set; }
        public virtual DbSet<code_company> code_company { get; set; }
        public virtual DbSet<code_gubun> code_gubun { get; set; }
        public virtual DbSet<code_index> code_index { get; set; }
        public virtual DbSet<code_machine_spec> code_machine_spec { get; set; }
        public virtual DbSet<code_main> code_main { get; set; }
        public virtual DbSet<code_material_spec> code_material_spec { get; set; }
        public virtual DbSet<code_nationality> code_nationality { get; set; }
        public virtual DbSet<code_position> code_position { get; set; }
        public virtual DbSet<code_product_spec> code_product_spec { get; set; }
        public virtual DbSet<code_project_state> code_project_state { get; set; }
        public virtual DbSet<code_sample> code_sample { get; set; }
        public virtual DbSet<code_time> code_time { get; set; }
        public virtual DbSet<code_work_state> code_work_state { get; set; }
        public virtual DbSet<company> company { get; set; }
        public virtual DbSet<department> department { get; set; }
        public virtual DbSet<event_list> event_list { get; set; }
        public virtual DbSet<file_list> file_list { get; set; }
        public virtual DbSet<file_menu> file_menu { get; set; }
        public virtual DbSet<goods> goods { get; set; }
        public virtual DbSet<goodsImg> goodsImg { get; set; }
        public virtual DbSet<history> history { get; set; }
        public virtual DbSet<language> language { get; set; }
        public virtual DbSet<machine> machine { get; set; }
        public virtual DbSet<material> material { get; set; }
        public virtual DbSet<member> member { get; set; }
        public virtual DbSet<member_list> member_list { get; set; }
        public virtual DbSet<my_work> my_work { get; set; }
        public virtual DbSet<photo> photo { get; set; }
        public virtual DbSet<project_act> project_act { get; set; }
        public virtual DbSet<project_dir> project_dir { get; set; }
        public virtual DbSet<project_main> project_main { get; set; }
        public virtual DbSet<project_main_back> project_main_back { get; set; }
        public virtual DbSet<sample> sample { get; set; }
        public virtual DbSet<user> user { get; set; }
        public virtual DbSet<user_mail> user_mail { get; set; }
        public virtual DbSet<v_mywork_project> v_mywork_project { get; set; }
        public virtual DbSet<v_new_work> v_new_work { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:180.210.34.49,1433;Initial Catalog=smartFactory;Persist Security Info=True;User ID=smartfactory_user;Password=smartfactory_user0037;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=True;Connection Timeout=300;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");
            });

            modelBuilder.Entity<Avoidance>(entity =>
            {
                entity.Property(e => e.Collision).IsUnicode(false);

                entity.Property(e => e.page_name).IsUnicode(false);

                entity.Property(e => e.r_date).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BoardCode>(entity =>
            {
                entity.Property(e => e.code_id).ValueGeneratedNever();

                entity.Property(e => e.board_auth).IsUnicode(false);

                entity.Property(e => e.code_name)
                    .IsUnicode(false)
                    .HasComment("중류");

                entity.Property(e => e.gubun).IsUnicode(false);

                entity.Property(e => e.use_yn).IsUnicode(false);
            });

            modelBuilder.Entity<BoardComment>(entity =>
            {
                entity.HasKey(e => e.idx)
                    .HasName("PK_bbs_comment");

                entity.Property(e => e.edit_date).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.step).HasDefaultValueSql("((1))");

                entity.Property(e => e.use_yn).IsUnicode(false);

                entity.Property(e => e.user_ip).IsUnicode(false);

                entity.Property(e => e.write_date).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.writer).IsUnicode(false);

                entity.HasOne(d => d.BD_idxNavigation)
                    .WithMany(p => p.BoardComment)
                    .HasForeignKey(d => d.BD_idx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BoardComment_Board");
            });

            modelBuilder.Entity<BoardFile>(entity =>
            {
                entity.Property(e => e.ImagePath).IsUnicode(false);

                entity.Property(e => e.Md_id)
                    .IsUnicode(false)
                    .HasComment("파일 고유 키");

                entity.Property(e => e.fileName).IsUnicode(false);

                entity.Property(e => e.file_ex).IsUnicode(false);

                entity.Property(e => e.sImagePath).IsUnicode(false);

                entity.Property(e => e.use_yn).IsUnicode(false);

                entity.Property(e => e.write_id).IsUnicode(false);
            });

            modelBuilder.Entity<BoardList>(entity =>
            {
                entity.HasKey(e => e.idx)
                    .HasName("PK_Board");

                entity.Property(e => e.BM_idx).HasComment("게시판 메뉴 인덱스");

                entity.Property(e => e.delDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("삭제일");

                entity.Property(e => e.editDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("수정일");

                entity.Property(e => e.fileId).IsUnicode(false);

                entity.Property(e => e.password).IsUnicode(false);

                entity.Property(e => e.title).IsUnicode(false);

                entity.Property(e => e.useable)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))")
                    .HasComment("게시글 사용 여부 (Y/N)");

                entity.Property(e => e.writeDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.writer).IsUnicode(false);

                entity.HasOne(d => d.BM_idxNavigation)
                    .WithMany(p => p.BoardList)
                    .HasForeignKey(d => d.BM_idx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BoardList_BoardMenu");
            });

            modelBuilder.Entity<BoardMenu>(entity =>
            {
                entity.Property(e => e.BoardType_idx).HasComment("게시판 종류");

                entity.Property(e => e.index_order).HasDefaultValueSql("((999))");

                entity.Property(e => e.open_yn).IsUnicode(false);

                entity.Property(e => e.title).IsUnicode(false);

                entity.Property(e => e.url).IsUnicode(false);

                entity.HasOne(d => d.BoardType_idxNavigation)
                    .WithMany(p => p.BoardMenu)
                    .HasForeignKey(d => d.BoardType_idx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BoardMenu_BoardCode");

                entity.HasOne(d => d.company_idxNavigation)
                    .WithMany(p => p.BoardMenu)
                    .HasForeignKey(d => d.company_idx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BoardMenu_company");

                entity.HasOne(d => d.department_idxNavigation)
                    .WithMany(p => p.BoardMenu)
                    .HasForeignKey(d => d.department_idx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BoardMenu_department");
            });

            modelBuilder.Entity<BoardRread>(entity =>
            {
                entity.HasKey(e => e.idx)
                    .HasName("PK_board_read");

                entity.Property(e => e.user_id).IsUnicode(false);

                entity.Property(e => e.user_name).IsUnicode(false);

                entity.HasOne(d => d.board_idxNavigation)
                    .WithMany(p => p.BoardRread)
                    .HasForeignKey(d => d.board_idx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BoardRread_Board");

                entity.HasOne(d => d.user_)
                    .WithMany(p => p.BoardRread)
                    .HasForeignKey(d => d.user_id)
                    .HasConstraintName("FK_BoardRread_user");
            });

            modelBuilder.Entity<CategoryMenus>(entity =>
            {
                entity.Property(e => e.company_id).IsUnicode(false);

                entity.Property(e => e.step_auth).IsUnicode(false);

                entity.Property(e => e.step_dept).HasDefaultValueSql("((1))");

                entity.Property(e => e.step_icon).IsUnicode(false);

                entity.Property(e => e.step_index)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.step_name).IsUnicode(false);

                entity.Property(e => e.step_orderby).HasDefaultValueSql("((9))");

                entity.Property(e => e.step_url1).IsUnicode(false);

                entity.Property(e => e.step_url2).IsUnicode(false);

                entity.Property(e => e.step_writedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Md_Image>(entity =>
            {
                entity.Property(e => e.ImagePath).IsUnicode(false);

                entity.Property(e => e.Md_id).IsUnicode(false);

                entity.Property(e => e.fileName).IsUnicode(false);

                entity.Property(e => e.file_ex).IsUnicode(false);

                entity.Property(e => e.file_size).HasDefaultValueSql("((0))");

                entity.Property(e => e.index_order).HasDefaultValueSql("((999))");

                entity.Property(e => e.sImagePath).IsUnicode(false);

                entity.Property(e => e.use_yn).IsUnicode(false);

                entity.Property(e => e.write_id).IsUnicode(false);
            });

            modelBuilder.Entity<New_work>(entity =>
            {
                entity.Property(e => e.user_id).IsUnicode(false);

                entity.HasOne(d => d.project_)
                    .WithMany(p => p.New_work)
                    .HasForeignKey(d => d.project_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_New_work_project_main");

                entity.HasOne(d => d.user_)
                    .WithMany(p => p.New_work)
                    .HasForeignKey(d => d.user_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_New_work_user");
            });

            modelBuilder.Entity<Process>(entity =>
            {
                entity.HasKey(e => e.Num)
                    .HasName("PK_process");

                entity.Property(e => e.Num).ValueGeneratedNever();

                entity.Property(e => e.gubun).IsUnicode(false);

                entity.Property(e => e.pic1).IsUnicode(false);

                entity.Property(e => e.pic2).IsUnicode(false);

                entity.Property(e => e.title).IsUnicode(false);

                entity.Property(e => e.writer_name).IsUnicode(false);

                entity.Property(e => e.wrtie_date).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.pName).IsUnicode(false);

                entity.Property(e => e.product_idx).HasComment("회사코드");

                entity.Property(e => e.use_yn).IsUnicode(false);

                entity.Property(e => e.writeDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.code_product_spec_idxNavigation)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.code_product_spec_idx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_code_product_spec");
            });

            modelBuilder.Entity<QA>(entity =>
            {
                entity.Property(e => e.gubun).IsUnicode(false);

                entity.Property(e => e.pic1).IsUnicode(false);

                entity.Property(e => e.pic2).IsUnicode(false);

                entity.Property(e => e.title).IsUnicode(false);

                entity.Property(e => e.writer_name).IsUnicode(false);

                entity.Property(e => e.wrtie_date).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<cal_memo>(entity =>
            {
                entity.Property(e => e.company_id).IsUnicode(false);

                entity.Property(e => e.department_id).IsUnicode(false);

                entity.Property(e => e.end_date).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.file_sn).IsUnicode(false);

                entity.Property(e => e.gubun_type)
                    .IsUnicode(false)
                    .HasComment("프로젝트 코드");

                entity.Property(e => e.project_idx).HasComment("프로젝트 고유코드");

                entity.Property(e => e.title).IsUnicode(false);

                entity.Property(e => e.use_yn)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.user_id).IsUnicode(false);

                entity.HasOne(d => d.project_idxNavigation)
                    .WithMany(p => p.cal_memo)
                    .HasForeignKey(d => d.project_idx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cal_memo_project_main");

                entity.HasOne(d => d.user_)
                    .WithMany(p => p.cal_memo)
                    .HasForeignKey(d => d.user_id)
                    .HasConstraintName("FK_cal_memo_cal_user");
            });

            modelBuilder.Entity<calendar>(entity =>
            {
                entity.HasKey(e => e.idx)
                    .HasName("PK_work_list");

                entity.Property(e => e.code_work_idx)
                    .HasDefaultValueSql("((1))")
                    .HasComment("작업 상태");

                entity.Property(e => e.content).HasComment("비고");

                entity.Property(e => e.edit_date).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.end_date).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.fileId)
                    .IsUnicode(false)
                    .HasComment("첨부파일 아이디");

                entity.Property(e => e.gubun_type)
                    .IsUnicode(false)
                    .HasComment("프로젝트 코드");

                entity.Property(e => e.open_it)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.project_idx).HasComment("프로젝트 고유코드");

                entity.Property(e => e.start_date).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.title).IsUnicode(false);

                entity.Property(e => e.use_yn)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')")
                    .HasComment("사용여부");

                entity.Property(e => e.user_id).IsUnicode(false);

                entity.Property(e => e.who)
                    .IsUnicode(false)
                    .HasComment("참여인력");

                entity.Property(e => e.who_list).IsUnicode(false);

                entity.Property(e => e.work_hour).HasComment("작업시간");

                entity.Property(e => e.write_date).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.code_index_idxNavigation)
                    .WithMany(p => p.calendar)
                    .HasForeignKey(d => d.code_index_idx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_work_list_code_work_state");

                entity.HasOne(d => d.company_idxNavigation)
                    .WithMany(p => p.calendar)
                    .HasForeignKey(d => d.company_idx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_work_list_company");

                entity.HasOne(d => d.department_idxNavigation)
                    .WithMany(p => p.calendar)
                    .HasForeignKey(d => d.department_idx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_work_list_department");

                entity.HasOne(d => d.project_idxNavigation)
                    .WithMany(p => p.calendar)
                    .HasForeignKey(d => d.project_idx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_work_list_project_main");

                entity.HasOne(d => d.user_)
                    .WithMany(p => p.calendar)
                    .HasForeignKey(d => d.user_id)
                    .HasConstraintName("FK_work_list_user");
            });

            modelBuilder.Entity<code_1>(entity =>
            {
                entity.HasKey(e => e.idx)
                    .HasName("PK_code_1_1");

                entity.Property(e => e.code_name).IsUnicode(false);

                entity.Property(e => e.code_name_ko).IsUnicode(false);

                entity.Property(e => e.gubun).IsUnicode(false);

                entity.Property(e => e.index_order).HasDefaultValueSql("((99))");

                entity.Property(e => e.lan_type).IsUnicode(false);

                entity.Property(e => e.use_yn).IsUnicode(false);
            });

            modelBuilder.Entity<code_auth>(entity =>
            {
                entity.Property(e => e.code_id).ValueGeneratedNever();

                entity.Property(e => e.code_name).IsUnicode(false);

                entity.Property(e => e.gubun).IsUnicode(false);

                entity.Property(e => e.url).IsUnicode(false);

                entity.Property(e => e.use_yn).IsUnicode(false);
            });

            modelBuilder.Entity<code_auth_ex>(entity =>
            {
                entity.Property(e => e.code_name).IsUnicode(false);

                entity.Property(e => e.gubun).IsUnicode(false);

                entity.Property(e => e.url).IsUnicode(false);

                entity.Property(e => e.use_yn).IsUnicode(false);
            });

            modelBuilder.Entity<code_company>(entity =>
            {
                entity.Property(e => e.code_name).IsUnicode(false);

                entity.Property(e => e.gubun).IsUnicode(false);

                entity.Property(e => e.use_yn).IsUnicode(false);
            });

            modelBuilder.Entity<code_gubun>(entity =>
            {
                entity.Property(e => e.code_id).IsUnicode(false);

                entity.Property(e => e.code_name)
                    .IsUnicode(false)
                    .HasComment("중류");

                entity.Property(e => e.code_name_en)
                    .IsUnicode(false)
                    .HasComment("중류");

                entity.Property(e => e.gubun).IsUnicode(false);

                entity.Property(e => e.use_yn).IsUnicode(false);
            });

            modelBuilder.Entity<code_index>(entity =>
            {
                entity.Property(e => e.code_name).IsUnicode(false);

                entity.Property(e => e.gubun).IsUnicode(false);

                entity.Property(e => e.use_yn).IsUnicode(false);
            });

            modelBuilder.Entity<code_machine_spec>(entity =>
            {
                entity.Property(e => e.code_name)
                    .IsUnicode(false)
                    .HasComment("중류");

                entity.Property(e => e.code_name_en)
                    .IsUnicode(false)
                    .HasComment("중류");

                entity.Property(e => e.gubun).IsUnicode(false);

                entity.Property(e => e.use_yn).IsUnicode(false);
            });

            modelBuilder.Entity<code_main>(entity =>
            {
                entity.Property(e => e.idx).ValueGeneratedNever();

                entity.Property(e => e.code_id).IsUnicode(false);

                entity.Property(e => e.code_name)
                    .IsUnicode(false)
                    .HasComment("중류");

                entity.Property(e => e.gubun).IsUnicode(false);

                entity.Property(e => e.project_name).IsUnicode(false);

                entity.Property(e => e.use_yn).IsUnicode(false);
            });

            modelBuilder.Entity<code_material_spec>(entity =>
            {
                entity.Property(e => e.code_name)
                    .IsUnicode(false)
                    .HasComment("중류");

                entity.Property(e => e.code_name_en)
                    .IsUnicode(false)
                    .HasComment("중류");

                entity.Property(e => e.gubun).IsUnicode(false);

                entity.Property(e => e.use_yn).IsUnicode(false);
            });

            modelBuilder.Entity<code_nationality>(entity =>
            {
                entity.HasKey(e => e.code_id)
                    .HasName("PK_code_1");

                entity.Property(e => e.code_id).IsUnicode(false);

                entity.Property(e => e.gubun).IsUnicode(false);

                entity.Property(e => e.use_yn).IsUnicode(false);

                entity.Property(e => e.write_date).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.writer_id).IsUnicode(false);
            });

            modelBuilder.Entity<code_position>(entity =>
            {
                entity.Property(e => e.code_name)
                    .IsUnicode(false)
                    .HasComment("중류");

                entity.Property(e => e.code_name_en)
                    .IsUnicode(false)
                    .HasComment("중류");

                entity.Property(e => e.gubun).IsUnicode(false);

                entity.Property(e => e.use_yn).IsUnicode(false);

                entity.HasOne(d => d.company_idxNavigation)
                    .WithMany(p => p.code_position)
                    .HasForeignKey(d => d.company_idx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_code_position_company");
            });

            modelBuilder.Entity<code_product_spec>(entity =>
            {
                entity.Property(e => e.code_name)
                    .IsUnicode(false)
                    .HasComment("중류");

                entity.Property(e => e.code_name_en)
                    .IsUnicode(false)
                    .HasComment("중류");

                entity.Property(e => e.gubun).IsUnicode(false);

                entity.Property(e => e.use_yn).IsUnicode(false);
            });

            modelBuilder.Entity<code_project_state>(entity =>
            {
                entity.Property(e => e.code_id).ValueGeneratedNever();

                entity.Property(e => e.code_name).IsUnicode(false);

                entity.Property(e => e.gubun).IsUnicode(false);

                entity.Property(e => e.use_yn).IsUnicode(false);
            });

            modelBuilder.Entity<code_sample>(entity =>
            {
                entity.Property(e => e.code_name)
                    .IsUnicode(false)
                    .HasComment("중류");

                entity.Property(e => e.code_name_en)
                    .IsUnicode(false)
                    .HasComment("중류");

                entity.Property(e => e.gubun).IsUnicode(false);

                entity.Property(e => e.use_yn).IsUnicode(false);
            });

            modelBuilder.Entity<code_time>(entity =>
            {
                entity.Property(e => e.code_id).ValueGeneratedNever();

                entity.Property(e => e.code_name).IsUnicode(false);

                entity.Property(e => e.gubun).IsUnicode(false);

                entity.Property(e => e.use_yn).IsUnicode(false);
            });

            modelBuilder.Entity<code_work_state>(entity =>
            {
                entity.Property(e => e.code_name)
                    .IsUnicode(false)
                    .HasComment("중류");

                entity.Property(e => e.code_name_en)
                    .IsUnicode(false)
                    .HasComment("중류");

                entity.Property(e => e.gubun).IsUnicode(false);

                entity.Property(e => e.use_yn).IsUnicode(false);
            });

            modelBuilder.Entity<company>(entity =>
            {
                entity.HasKey(e => e.idx)
                    .HasName("PK_company_1");

                entity.Property(e => e.ceo_name).IsUnicode(false);

                entity.Property(e => e.company_id)
                    .IsUnicode(false)
                    .HasComment("회사 아이디");

                entity.Property(e => e.company_name)
                    .IsUnicode(false)
                    .HasComment("회사명");

                entity.Property(e => e.file_id).IsUnicode(false);

                entity.Property(e => e.gubun_idx).HasComment("회사 종류(본점, 거래처, 지점 , 협력사 등) code_company");

                entity.Property(e => e.index_order).HasDefaultValueSql("((9))");

                entity.Property(e => e.juso).IsUnicode(false);

                entity.Property(e => e.nationality)
                    .IsUnicode(false)
                    .HasComment("국적 코드");

                entity.Property(e => e.saupja_number).IsUnicode(false);

                entity.Property(e => e.use_yn)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.work_jongmok).IsUnicode(false);

                entity.Property(e => e.work_uptae).IsUnicode(false);

                entity.Property(e => e.write_date).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.gubun_idxNavigation)
                    .WithMany(p => p.company)
                    .HasForeignKey(d => d.gubun_idx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_company_code_company");
            });

            modelBuilder.Entity<department>(entity =>
            {
                entity.HasKey(e => e.idx)
                    .HasName("PK_department_1");

                entity.Property(e => e.company_idx).HasComment(" 회사 아이디");

                entity.Property(e => e.department_auth)
                    .IsUnicode(false)
                    .HasComment("부서 권한");

                entity.Property(e => e.department_name)
                    .IsUnicode(false)
                    .HasComment("부서명");

                entity.Property(e => e.use_yn)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.write_date).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.company_idxNavigation)
                    .WithMany(p => p.department)
                    .HasForeignKey(d => d.company_idx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_department_company");
            });

            modelBuilder.Entity<event_list>(entity =>
            {
                entity.Property(e => e.f_city)
                    .IsUnicode(false)
                    .HasComment("도시");

                entity.Property(e => e.f_name).IsUnicode(false);

                entity.Property(e => e.f_nation_id).HasComment("주최국가");

                entity.Property(e => e.index_order).HasDefaultValueSql("((999))");

                entity.Property(e => e.r_date)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("행사일");

                entity.Property(e => e.use_yn).IsUnicode(false);
            });

            modelBuilder.Entity<file_list>(entity =>
            {
                entity.HasKey(e => e.idx)
                    .HasName("PK_file_list_1");

                entity.Property(e => e.file_idx)
                    .IsUnicode(false)
                    .HasComment("대상 idx");

                entity.Property(e => e.file_menu_id)
                    .HasDefaultValueSql("((0))")
                    .HasComment("파일 메뉴");

                entity.Property(e => e.file_name)
                    .IsUnicode(false)
                    .HasComment("파일 이름");

                entity.Property(e => e.file_pre_name)
                    .IsUnicode(false)
                    .HasComment("파일 원본 이름");

                entity.Property(e => e.file_size).HasComment("파일 크기");

                entity.Property(e => e.file_type)
                    .IsUnicode(false)
                    .HasComment("파일 형식");

                entity.Property(e => e.hit).HasComment("조회수");

                entity.Property(e => e.write_date)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("등록일");

                entity.HasOne(d => d.file_menu_)
                    .WithMany(p => p.file_list)
                    .HasForeignKey(d => d.file_menu_id)
                    .HasConstraintName("FK_file_list_file_menu");
            });

            modelBuilder.Entity<file_menu>(entity =>
            {
                entity.Property(e => e.file_menu_name).IsUnicode(false);

                entity.Property(e => e.use_yn).IsUnicode(false);

                entity.Property(e => e.write_date).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<goods>(entity =>
            {
                entity.Property(e => e.OpenYn)
                    .IsUnicode(false)
                    .HasComment("상품 게시 여부");

                entity.Property(e => e.admin_memo).IsUnicode(false);

                entity.Property(e => e.basicPrice).HasComment("기준 제품가");

                entity.Property(e => e.delDate).HasComment("삭제일");

                entity.Property(e => e.delYn)
                    .IsUnicode(false)
                    .HasComment("삭제 여부 Y / N");

                entity.Property(e => e.discount).HasComment("할인률");

                entity.Property(e => e.distributionPeriod)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("유통기간");

                entity.Property(e => e.endDay)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("제품 판매 종료일");

                entity.Property(e => e.goodsAdvantage)
                    .IsUnicode(false)
                    .HasComment("특징 및 장점");

                entity.Property(e => e.goodsImageId).HasComment("관련 제품 이미지 아이디");

                entity.Property(e => e.goodsInfo)
                    .IsUnicode(false)
                    .HasComment("제품 간단 소개");

                entity.Property(e => e.goodsLanguage)
                    .IsUnicode(false)
                    .HasComment("한글:  ko / 영문 :en");

                entity.Property(e => e.goodsMainImage)
                    .IsUnicode(false)
                    .HasComment("제품 메인 사진");

                entity.Property(e => e.goodsMainImageSmall)
                    .IsUnicode(false)
                    .HasComment("제품 메인 사진");

                entity.Property(e => e.goodsMemo).HasComment("상품설명");

                entity.Property(e => e.goodsName).IsUnicode(false);

                entity.Property(e => e.goodsRecommendation)
                    .IsUnicode(false)
                    .HasComment("상품추천");

                entity.Property(e => e.goodsSubImage)
                    .IsUnicode(false)
                    .HasComment("제품 메인 사진");

                entity.Property(e => e.goodsTypeId).HasComment("상품 종류 구분 아이디");

                entity.Property(e => e.index_order).HasDefaultValueSql("((999))");

                entity.Property(e => e.manufacturingDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("제조일");

                entity.Property(e => e.rdate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.residualQuantity).HasComment("잔여수량");

                entity.Property(e => e.sellPrice).HasComment("판매가");

                entity.Property(e => e.sellPriceEn).HasComment("판매가 영문");

                entity.Property(e => e.soldOutYn)
                    .IsUnicode(false)
                    .HasComment("매진여부");

                entity.Property(e => e.specialAgreement)
                    .IsUnicode(false)
                    .HasComment("특약사항");

                entity.Property(e => e.startDay)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("제품 판매 시작일");

                entity.Property(e => e.totalQuantity).HasComment("총수량");
            });

            modelBuilder.Entity<goodsImg>(entity =>
            {
                entity.Property(e => e.ImagePath).IsUnicode(false);

                entity.Property(e => e.index_order).HasDefaultValueSql("((999))");

                entity.Property(e => e.sImagePath).IsUnicode(false);

                entity.Property(e => e.use_yn).IsUnicode(false);

                entity.Property(e => e.write_id).IsUnicode(false);
            });

            modelBuilder.Entity<history>(entity =>
            {
                entity.Property(e => e.company_id).IsUnicode(false);

                entity.Property(e => e.connect_agent).IsUnicode(false);

                entity.Property(e => e.connect_date).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.connect_host).IsUnicode(false);

                entity.Property(e => e.connect_path).IsUnicode(false);

                entity.Property(e => e.department_id).IsUnicode(false);

                entity.Property(e => e.memo).IsUnicode(false);

                entity.Property(e => e.page).IsUnicode(false);

                entity.Property(e => e.pre_page).IsUnicode(false);

                entity.Property(e => e.state).IsUnicode(false);

                entity.Property(e => e.user_id).IsUnicode(false);

                entity.Property(e => e.user_ip).IsUnicode(false);

                entity.HasOne(d => d.user_)
                    .WithMany(p => p.history)
                    .HasForeignKey(d => d.user_id)
                    .HasConstraintName("FK_history_user");
            });

            modelBuilder.Entity<language>(entity =>
            {
                entity.Property(e => e.code_name).IsUnicode(false);

                entity.Property(e => e.english).IsUnicode(false);

                entity.Property(e => e.idx).ValueGeneratedOnAdd();

                entity.Property(e => e.korea).IsUnicode(false);
            });

            modelBuilder.Entity<machine>(entity =>
            {
                entity.Property(e => e.company_idx).HasComment("회사코드");

                entity.Property(e => e.mName).IsUnicode(false);

                entity.Property(e => e.use_yn).IsUnicode(false);

                entity.Property(e => e.writeDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.code_machine_spec_idxNavigation)
                    .WithMany(p => p.machine)
                    .HasForeignKey(d => d.code_machine_spec_idx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_machine_code_machine_spec");

                entity.HasOne(d => d.company_idxNavigation)
                    .WithMany(p => p.machine)
                    .HasForeignKey(d => d.company_idx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_machine_company");
            });

            modelBuilder.Entity<material>(entity =>
            {
                entity.Property(e => e.aName).IsUnicode(false);

                entity.Property(e => e.material_idx).HasComment("회사코드");

                entity.Property(e => e.use_yn).IsUnicode(false);

                entity.Property(e => e.writeDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.code_material_spec_idxNavigation)
                    .WithMany(p => p.material)
                    .HasForeignKey(d => d.code_material_spec_idx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_material_code_material_spec");
            });

            modelBuilder.Entity<member>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("member");

                entity.Property(e => e.company_id).IsUnicode(false);

                entity.Property(e => e.company_name).IsUnicode(false);

                entity.Property(e => e.department_auth).IsUnicode(false);

                entity.Property(e => e.department_id).IsUnicode(false);

                entity.Property(e => e.department_name).IsUnicode(false);

                entity.Property(e => e.nationality).IsUnicode(false);

                entity.Property(e => e.user_auth).IsUnicode(false);

                entity.Property(e => e.user_id).IsUnicode(false);

                entity.Property(e => e.user_name).IsUnicode(false);
            });

            modelBuilder.Entity<member_list>(entity =>
            {
                entity.Property(e => e.idx).ValueGeneratedNever();

                entity.Property(e => e.edate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.memo).IsUnicode(false);

                entity.Property(e => e.rdate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.userEmail).IsUnicode(false);

                entity.Property(e => e.userName).IsUnicode(false);

                entity.Property(e => e.userPassword).IsUnicode(false);
            });

            modelBuilder.Entity<my_work>(entity =>
            {
                entity.Property(e => e.content).HasComment("비고");

                entity.Property(e => e.edit_date).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.file_sn).IsUnicode(false);

                entity.Property(e => e.open_it)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.project_id).HasComment("프로젝트 고유코드");

                entity.Property(e => e.state)
                    .HasDefaultValueSql("((1))")
                    .HasComment("작업 상태");

                entity.Property(e => e.title).IsUnicode(false);

                entity.Property(e => e.use_yn)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')")
                    .HasComment("업무 분류");

                entity.Property(e => e.user_id).IsUnicode(false);

                entity.Property(e => e.work_time).HasComment("작업시간");

                entity.Property(e => e.write_date).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.project_)
                    .WithMany(p => p.my_work)
                    .HasForeignKey(d => d.project_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_my_work_project_main");

                entity.HasOne(d => d.user_)
                    .WithMany(p => p.my_work)
                    .HasForeignKey(d => d.user_id)
                    .HasConstraintName("FK_my_work_user");
            });

            modelBuilder.Entity<photo>(entity =>
            {
                entity.Property(e => e.ImagePath).IsUnicode(false);

                entity.Property(e => e.M_Category).HasComment("대회종류");

                entity.Property(e => e.M_gubun).IsUnicode(false);

                entity.Property(e => e.M_keyword).IsUnicode(false);

                entity.Property(e => e.M_season).HasComment("대회 시즌");

                entity.Property(e => e.code_city_id).HasComment("소속 도시");

                entity.Property(e => e.index_order).HasDefaultValueSql("((999))");

                entity.Property(e => e.sImagePath).IsUnicode(false);

                entity.Property(e => e.title).IsUnicode(false);

                entity.Property(e => e.title_en).IsUnicode(false);

                entity.Property(e => e.use_yn).IsUnicode(false);

                entity.Property(e => e.write_id).IsUnicode(false);

                entity.HasOne(d => d.M_seasonNavigation)
                    .WithMany(p => p.photo)
                    .HasForeignKey(d => d.M_season)
                    .HasConstraintName("FK_photo_event_list");
            });

            modelBuilder.Entity<project_act>(entity =>
            {
                entity.Property(e => e.end_date).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.maker_id).IsUnicode(false);

                entity.Property(e => e.manager).IsUnicode(false);

                entity.Property(e => e.memo).IsUnicode(false);

                entity.Property(e => e.project_sub_title).IsUnicode(false);

                entity.Property(e => e.set_time).HasComment("설정된 시간 또는 일");

                entity.Property(e => e.start_date).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.state_id).HasComment("작업 상태 완료 , 시작");

                entity.Property(e => e.work_per).HasComment("작업 비중");

                entity.Property(e => e.write_date).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.maker_)
                    .WithMany(p => p.project_actmaker_)
                    .HasForeignKey(d => d.maker_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_project_act_user");

                entity.HasOne(d => d.managerNavigation)
                    .WithMany(p => p.project_actmanagerNavigation)
                    .HasForeignKey(d => d.manager)
                    .HasConstraintName("FK_project_act_manager");

                entity.HasOne(d => d.project_dir_idxNavigation)
                    .WithMany(p => p.project_act)
                    .HasForeignKey(d => d.project_dir_idx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_project_act_project_dir");

                entity.HasOne(d => d.project_)
                    .WithMany(p => p.project_act)
                    .HasForeignKey(d => d.project_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_project_act_project_main");
            });

            modelBuilder.Entity<project_dir>(entity =>
            {
                entity.Property(e => e.end_date).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.maker_id).IsUnicode(false);

                entity.Property(e => e.project_dir_title).IsUnicode(false);

                entity.Property(e => e.project_step).HasDefaultValueSql("((1))");

                entity.Property(e => e.start_date).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.maker_)
                    .WithMany(p => p.project_dir)
                    .HasForeignKey(d => d.maker_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_project_dir_user");

                entity.HasOne(d => d.project_)
                    .WithMany(p => p.project_dir)
                    .HasForeignKey(d => d.project_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_project_dir_project_main");
            });

            modelBuilder.Entity<project_main>(entity =>
            {
                entity.Property(e => e.end_date)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("종료일");

                entity.Property(e => e.file_sn).IsUnicode(false);

                entity.Property(e => e.index_order).HasDefaultValueSql("((9))");

                entity.Property(e => e.memo).IsUnicode(false);

                entity.Property(e => e.mode_type)
                    .IsUnicode(false)
                    .HasComment("장비 제작 관리 연동 ");

                entity.Property(e => e.owner_id).IsUnicode(false);

                entity.Property(e => e.project_name)
                    .IsUnicode(false)
                    .HasComment("프로젝트 이름");

                entity.Property(e => e.start_date)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("시작일");

                entity.Property(e => e.state)
                    .HasDefaultValueSql("((1))")
                    .HasComment("진행상태(준비중,진행중 등)");

                entity.Property(e => e.use_yn)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.write_date).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.writer).IsUnicode(false);
            });

            modelBuilder.Entity<project_main_back>(entity =>
            {
                entity.Property(e => e.company_id).IsUnicode(false);

                entity.Property(e => e.department_id).IsUnicode(false);

                entity.Property(e => e.file_sn).IsUnicode(false);

                entity.Property(e => e.memo).IsUnicode(false);

                entity.Property(e => e.mode_type).IsUnicode(false);

                entity.Property(e => e.project_code).IsUnicode(false);

                entity.Property(e => e.project_id_name).IsUnicode(false);

                entity.Property(e => e.project_name).IsUnicode(false);

                entity.Property(e => e.use_yn).IsUnicode(false);

                entity.Property(e => e.writer).IsUnicode(false);
            });

            modelBuilder.Entity<sample>(entity =>
            {
                entity.Property(e => e.title).IsUnicode(false);

                entity.Property(e => e.use_yn).IsUnicode(false);

                entity.Property(e => e.userName).IsUnicode(false);

                entity.Property(e => e.writeDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.code_sample_idxNavigation)
                    .WithMany(p => p.sample)
                    .HasForeignKey(d => d.code_sample_idx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sample_code_sample");
            });

            modelBuilder.Entity<user>(entity =>
            {
                entity.Property(e => e.user_id)
                    .IsUnicode(false)
                    .HasComment("사용자 아이디");

                entity.Property(e => e.check_auth).HasDefaultValueSql("((1))");

                entity.Property(e => e.company_idx).HasComment("회사 아이디");

                entity.Property(e => e.department_idx).HasComment("부서 아이디");

                entity.Property(e => e.edit_date).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.idx).ValueGeneratedOnAdd();

                entity.Property(e => e.language).IsUnicode(false);

                entity.Property(e => e.main_bg_color)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('red')");

                entity.Property(e => e.manager_yn).IsUnicode(false);

                entity.Property(e => e.photo_profile).IsUnicode(false);

                entity.Property(e => e.use_yn)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.user_auth)
                    .IsUnicode(false)
                    .HasComment("사용자 권한");

                entity.Property(e => e.user_email).IsUnicode(false);

                entity.Property(e => e.user_name)
                    .IsUnicode(false)
                    .HasComment("사용자 명");

                entity.Property(e => e.user_password).IsUnicode(false);

                entity.Property(e => e.user_tel).IsUnicode(false);

                entity.Property(e => e.write_date).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.writer).IsUnicode(false);

                entity.HasOne(d => d.check_authNavigation)
                    .WithMany(p => p.user)
                    .HasForeignKey(d => d.check_auth)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_user_code_auth");

                entity.HasOne(d => d.company_idxNavigation)
                    .WithMany(p => p.user)
                    .HasForeignKey(d => d.company_idx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_user_company");

                entity.HasOne(d => d.department_idxNavigation)
                    .WithMany(p => p.user)
                    .HasForeignKey(d => d.department_idx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_user_department");

                entity.HasOne(d => d.position_idxNavigation)
                    .WithMany(p => p.user)
                    .HasForeignKey(d => d.position_idx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_user_code_position");
            });

            modelBuilder.Entity<user_mail>(entity =>
            {
                entity.Property(e => e.password).IsUnicode(false);

                entity.Property(e => e.rdate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.use_yn).IsUnicode(false);

                entity.Property(e => e.user_email).IsUnicode(false);
            });

            modelBuilder.Entity<v_mywork_project>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_mywork_project");

                entity.Property(e => e.project_name).IsUnicode(false);
            });

            modelBuilder.Entity<v_new_work>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_new_work");

                entity.Property(e => e.project_name).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
