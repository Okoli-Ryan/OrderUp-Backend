﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderUp_API.Data;

#nullable disable

namespace OrderUpAPI.Migrations
{
    [DbContext(typeof(OrderUpDbContext))]
    [Migration("20231011133453_orderitem_order_notmapped")]
    partial class orderitemordernotmapped
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("OrderUp_API.Models.Admin", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<bool>("ActiveStatus")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("active_status");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("first_name");

                    b.Property<bool>("IsEmailConfirmed")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_email_confirmed");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)")
                        .HasColumnName("password");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("phone_number");

                    b.Property<Guid?>("RestaurantID")
                        .HasColumnType("char(36)")
                        .HasColumnName("restaurant_id");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)")
                        .HasColumnName("role");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("ID")
                        .HasName("pk_admin");

                    b.HasIndex("RestaurantID")
                        .HasDatabaseName("ix_admin_restaurant_id");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("OrderUp_API.Models.MenuCategory", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<bool>("ActiveStatus")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("active_status");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("category_name");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<int>("Order")
                        .HasColumnType("int")
                        .HasColumnName("order");

                    b.Property<Guid>("RestaurantID")
                        .HasColumnType("char(36)")
                        .HasColumnName("restaurant_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("ID")
                        .HasName("pk_menu_category");

                    b.HasIndex("RestaurantID")
                        .HasDatabaseName("ix_menu_category_restaurant_id");

                    b.ToTable("menu_category", (string)null);
                });

            modelBuilder.Entity("OrderUp_API.Models.MenuItem", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<bool>("ActiveStatus")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("active_status");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)")
                        .HasColumnName("description");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("image_url");

                    b.Property<Guid>("MenuCategoryID")
                        .HasColumnType("char(36)")
                        .HasColumnName("menu_category_id");

                    b.Property<string>("MenuItemName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("menu_item_name");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("price");

                    b.Property<Guid>("RestaurantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("restaurant_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("ID")
                        .HasName("pk_menu_items");

                    b.HasIndex("MenuCategoryID")
                        .HasDatabaseName("ix_menu_items_menu_category_id");

                    b.ToTable("menu_items", (string)null);
                });

            modelBuilder.Entity("OrderUp_API.Models.MenuItemImage", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<bool>("ActiveStatus")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("active_status");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("image_url");

                    b.Property<Guid>("MenuItemID")
                        .HasColumnType("char(36)")
                        .HasColumnName("menu_item_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("ID")
                        .HasName("pk_menu_item_images");

                    b.HasIndex("MenuItemID")
                        .HasDatabaseName("ix_menu_item_images_menu_item_id");

                    b.ToTable("menu_item_images", (string)null);
                });

            modelBuilder.Entity("OrderUp_API.Models.Order", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<bool>("ActiveStatus")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("active_status");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<decimal?>("OrderAmount")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("order_amount");

                    b.Property<string>("OrderNote")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("order_note");

                    b.Property<string>("OrderStatus")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("order_status");

                    b.Property<string>("PaymentOption")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("payment_option");

                    b.Property<Guid>("RestaurantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("restaurant_id");

                    b.Property<Guid?>("TableID")
                        .HasColumnType("char(36)")
                        .HasColumnName("table_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.Property<Guid?>("UserID")
                        .HasColumnType("char(36)")
                        .HasColumnName("user_id");

                    b.HasKey("ID")
                        .HasName("pk_order");

                    b.HasIndex("TableID")
                        .HasDatabaseName("ix_order_table_id");

                    b.ToTable("order", (string)null);
                });

            modelBuilder.Entity("OrderUp_API.Models.OrderItem", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<bool>("ActiveStatus")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("active_status");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<Guid>("MenuItemID")
                        .HasColumnType("char(36)")
                        .HasColumnName("menu_item_id");

                    b.Property<string>("MenuItemName")
                        .HasColumnType("longtext")
                        .HasColumnName("menu_item_name");

                    b.Property<Guid>("OrderID")
                        .HasColumnType("char(36)")
                        .HasColumnName("order_id");

                    b.Property<decimal>("OrderItemPrice")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("order_item_price");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("ID")
                        .HasName("pk_order_item");

                    b.HasIndex("MenuItemID")
                        .HasDatabaseName("ix_order_item_menu_item_id");

                    b.HasIndex("OrderID")
                        .HasDatabaseName("ix_order_item_order_id");

                    b.ToTable("order_item", (string)null);
                });

            modelBuilder.Entity("OrderUp_API.Models.Restaurant", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<bool>("ActiveStatus")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("active_status");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("address");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("city");

                    b.Property<string>("ContactEmailAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("contact_email_address");

                    b.Property<string>("ContactPhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("contact_phone_number");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("country");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<string>("LogoUrl")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("logo_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("slug");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("state");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.Property<decimal>("XCoordinate")
                        .HasPrecision(18, 5)
                        .HasColumnType("decimal(18,5)")
                        .HasColumnName("x_coordinate");

                    b.Property<decimal>("YCoordinate")
                        .HasPrecision(18, 5)
                        .HasColumnType("decimal(18,5)")
                        .HasColumnName("y_coordinate");

                    b.HasKey("ID")
                        .HasName("pk_restaurants");

                    b.HasIndex("Slug")
                        .IsUnique()
                        .HasDatabaseName("ix_restaurants_slug");

                    b.ToTable("restaurants", (string)null);
                });

            modelBuilder.Entity("OrderUp_API.Models.SavedRestaurant", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<bool>("ActiveStatus")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("active_status");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<Guid>("RestaurantID")
                        .HasColumnType("char(36)")
                        .HasColumnName("restaurant_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.Property<Guid>("UserID")
                        .HasColumnType("char(36)")
                        .HasColumnName("user_id");

                    b.HasKey("ID")
                        .HasName("pk_saved_restaurants");

                    b.HasIndex("RestaurantID")
                        .HasDatabaseName("ix_saved_restaurants_restaurant_id");

                    b.HasIndex("UserID")
                        .HasDatabaseName("ix_saved_restaurants_user_id");

                    b.ToTable("saved_restaurants", (string)null);
                });

            modelBuilder.Entity("OrderUp_API.Models.SideItem", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<bool>("ActiveStatus")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("active_status");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("SideItemName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("side_item_name");

                    b.Property<decimal>("SideItemPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("side_item_price");

                    b.Property<Guid>("SidesID")
                        .HasColumnType("char(36)")
                        .HasColumnName("sides_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("ID")
                        .HasName("pk_side_items");

                    b.HasIndex("SidesID")
                        .HasDatabaseName("ix_side_items_sides_id");

                    b.ToTable("side_items", (string)null);
                });

            modelBuilder.Entity("OrderUp_API.Models.Sides", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<bool>("ActiveStatus")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("active_status");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<Guid>("MenuItemID")
                        .HasColumnType("char(36)")
                        .HasColumnName("menu_item_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("ID")
                        .HasName("pk_sides");

                    b.HasIndex("MenuItemID")
                        .HasDatabaseName("ix_sides_menu_item_id");

                    b.ToTable("sides", (string)null);
                });

            modelBuilder.Entity("OrderUp_API.Models.Table", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<bool>("ActiveStatus")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("active_status");

                    b.Property<string>("Code")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("code");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<Guid>("RestaurantID")
                        .HasColumnType("char(36)")
                        .HasColumnName("restaurant_id");

                    b.Property<string>("TableName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("table_name");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("ID")
                        .HasName("pk_tables");

                    b.HasIndex("RestaurantID")
                        .HasDatabaseName("ix_tables_restaurant_id");

                    b.ToTable("tables", (string)null);
                });

            modelBuilder.Entity("OrderUp_API.Models.User", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<bool>("ActiveStatus")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("active_status");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("first_name");

                    b.Property<bool>("IsEmailConfirmed")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_email_confirmed");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)")
                        .HasColumnName("password");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("phone_number");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.Property<string>("UserImageUrl")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("user_image_url");

                    b.HasKey("ID")
                        .HasName("pk_users");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasDatabaseName("ix_users_email");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("OrderUp_API.Models.VerificationCode", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<bool>("ActiveStatus")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("active_status");

                    b.Property<string>("Code")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("code");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("expiry_date");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.Property<Guid>("UserID")
                        .HasMaxLength(100)
                        .HasColumnType("char(100)")
                        .HasColumnName("user_id");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("user_type");

                    b.HasKey("ID")
                        .HasName("pk_verification_code");

                    b.ToTable("verification_code", (string)null);
                });

            modelBuilder.Entity("OrderUp_API.Models.Admin", b =>
                {
                    b.HasOne("OrderUp_API.Models.Restaurant", "Restaurant")
                        .WithMany("Admins")
                        .HasForeignKey("RestaurantID")
                        .HasConstraintName("fk_admin_restaurants_restaurant_id");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("OrderUp_API.Models.MenuCategory", b =>
                {
                    b.HasOne("OrderUp_API.Models.Restaurant", null)
                        .WithMany("MenuCategories")
                        .HasForeignKey("RestaurantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_menu_category_restaurants_restaurant_id");
                });

            modelBuilder.Entity("OrderUp_API.Models.MenuItem", b =>
                {
                    b.HasOne("OrderUp_API.Models.MenuCategory", null)
                        .WithMany("MenuItems")
                        .HasForeignKey("MenuCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_menu_items_menu_category_menu_category_id");
                });

            modelBuilder.Entity("OrderUp_API.Models.MenuItemImage", b =>
                {
                    b.HasOne("OrderUp_API.Models.MenuItem", "MenuItem")
                        .WithMany()
                        .HasForeignKey("MenuItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_menu_item_images_menu_items_menu_item_id");

                    b.Navigation("MenuItem");
                });

            modelBuilder.Entity("OrderUp_API.Models.Order", b =>
                {
                    b.HasOne("OrderUp_API.Models.Table", "Table")
                        .WithMany()
                        .HasForeignKey("TableID")
                        .HasConstraintName("fk_order_tables_table_id");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("OrderUp_API.Models.OrderItem", b =>
                {
                    b.HasOne("OrderUp_API.Models.MenuItem", "MenuItem")
                        .WithMany()
                        .HasForeignKey("MenuItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_order_item_menu_items_menu_item_id");

                    b.HasOne("OrderUp_API.Models.Order", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_order_item_order_order_id");

                    b.Navigation("MenuItem");
                });

            modelBuilder.Entity("OrderUp_API.Models.SavedRestaurant", b =>
                {
                    b.HasOne("OrderUp_API.Models.Restaurant", "Restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_saved_restaurants_restaurants_restaurant_id");

                    b.HasOne("OrderUp_API.Models.User", "User")
                        .WithMany("SavedRestaurants")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_saved_restaurants_users_user_id");

                    b.Navigation("Restaurant");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OrderUp_API.Models.SideItem", b =>
                {
                    b.HasOne("OrderUp_API.Models.Sides", "Sides")
                        .WithMany("SideItems")
                        .HasForeignKey("SidesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_side_items_sides_sides_id");

                    b.Navigation("Sides");
                });

            modelBuilder.Entity("OrderUp_API.Models.Sides", b =>
                {
                    b.HasOne("OrderUp_API.Models.MenuItem", "MenuItem")
                        .WithMany()
                        .HasForeignKey("MenuItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_sides_menu_items_menu_item_id");

                    b.Navigation("MenuItem");
                });

            modelBuilder.Entity("OrderUp_API.Models.Table", b =>
                {
                    b.HasOne("OrderUp_API.Models.Restaurant", "Restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_tables_restaurants_restaurant_id");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("OrderUp_API.Models.MenuCategory", b =>
                {
                    b.Navigation("MenuItems");
                });

            modelBuilder.Entity("OrderUp_API.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("OrderUp_API.Models.Restaurant", b =>
                {
                    b.Navigation("Admins");

                    b.Navigation("MenuCategories");
                });

            modelBuilder.Entity("OrderUp_API.Models.Sides", b =>
                {
                    b.Navigation("SideItems");
                });

            modelBuilder.Entity("OrderUp_API.Models.User", b =>
                {
                    b.Navigation("SavedRestaurants");
                });
#pragma warning restore 612, 618
        }
    }
}
