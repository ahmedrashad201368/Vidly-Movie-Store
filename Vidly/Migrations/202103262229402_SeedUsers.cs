namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'12a2c0fa-d9eb-4dd4-8f22-f618ac4d3d3b', N'admin@yahoo.com', 0, N'AKwJYr5LLb29xlGe720nq7MHJC19MNguwh1ie/HBrQNCBPN9NMTpUIJkjA/G2Nk5zQ==', N'a2d28fd2-956d-44c2-a16c-baeab8f042e8', NULL, 0, 0, NULL, 1, 0, N'admin@yahoo.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f1b1e7ef-20cf-4b65-ae99-f750c4941a53', N'guest@yahoo.com', 0, N'ADaZYrZeHxGIPh7QlKUEh9MQD9BYRzH1q9FlXQ0tjVGt2cmKPVg5CX47dpCsrHeyuQ==', N'ffb110c8-ced7-4880-9d6c-b57f398bcc9e', NULL, 0, 0, NULL, 1, 0, N'guest@yahoo.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ab8d5ae1-dfd2-40a0-a95c-b7a0f319924e', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'12a2c0fa-d9eb-4dd4-8f22-f618ac4d3d3b', N'ab8d5ae1-dfd2-40a0-a95c-b7a0f319924e')


");
        }
        
        public override void Down()
        {
        }
    }
}
