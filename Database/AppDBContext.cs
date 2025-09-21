using Microsoft.EntityFrameworkCore;

namespace Travel_Booking.Database;
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options){

}