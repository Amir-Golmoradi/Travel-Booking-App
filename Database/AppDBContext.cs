using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options){

}