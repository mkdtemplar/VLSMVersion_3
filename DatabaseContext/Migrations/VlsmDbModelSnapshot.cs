// <auto-generated />
using DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DatabaseContext.Migrations
{
    [DbContext(typeof(VlsmDb))]
    partial class VlsmDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("DatabaseContext.Vlsmresult", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("BroadcastId")
                        .HasColumnType("VARCHAR (45)")
                        .HasColumnName("broadcastID");

                    b.Property<string>("Cidr")
                        .HasColumnType("VARCHAR (45)")
                        .HasColumnName("CIDR");

                    b.Property<string>("NetworkId")
                        .HasColumnType("VARCHAR (45)")
                        .HasColumnName("NetworkID");

                    b.Property<string>("NumberOfHostsPerSubnet")
                        .HasColumnType("VARCHAR (45)");

                    b.Property<string>("NumberOfSubnets")
                        .HasColumnType("VARCHAR (45)");

                    b.Property<string>("RangeOfUsableIpaddresses")
                        .HasColumnType("VARCHAR (45)")
                        .HasColumnName("RangeOfUsableIPaddresses");

                    b.Property<string>("SubnetMask")
                        .HasColumnType("VARCHAR (45)");

                    b.HasKey("Id");

                    b.ToTable("Vlsmresults");
                });
#pragma warning restore 612, 618
        }
    }
}
