using BarberShopCodeFirstFromDB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;

namespace SeedDatabaseExtensions
{

	public static class SeedDatabaseExtensionMethods
    {
		/// <summary>
		/// zero out the db tables, then seed all tables with initial data
		/// </summary>
		public static void SeedDatabase(this BarberShopEntities context)
		{
			// set up database log to write to output window in VS
			context.Database.Log = (s => Debug.Write(s));

			// reset the db
			context.Database.Delete();
			context.Database.Create();

			context.SaveChanges();

			// another way to reinitialize the database, resetting everything and zeroing out data

			//Database.SetInitializer(new DropCreateDatabaseAlways<StudentRegistrationEntities>());
			//context.Database.Initialize(true);        

			context.Shifts.Load();
			context.Barbers.Load();
			context.Barber_shifts.Load();
			context.Shops.Load();
			context.Haircuts.Load();
			context.Users.Load();
			context.Barber_Avail.Load();
			context.Status.Load();
			context.Appointments.Load();


			// seed Shifts data
			List<Shift> shiftList = new List<Shift>()  {
					new Shift{shift_id=1, shift_start_time=TimeSpan.Parse("13:20:00") ,shift_end_time=TimeSpan.Parse("17:50:00")},
					new Shift{shift_id=2, shift_start_time=TimeSpan.Parse("14:20:00") ,shift_end_time=TimeSpan.Parse("16:50:00")},
					new Shift{shift_id=3, shift_start_time=TimeSpan.Parse("15:20:00") ,shift_end_time=TimeSpan.Parse("18:50:00")},
					new Shift{shift_id=4, shift_start_time=TimeSpan.Parse("16:20:00") ,shift_end_time=TimeSpan.Parse("16:50:00")},
					new Shift{shift_id=5, shift_start_time=TimeSpan.Parse("17:20:00") ,shift_end_time=TimeSpan.Parse("19:50:00")},
			};

			// use a dictionary to set the shift_id fields in  Barber_shifts
			Dictionary<int, Shift> shifts = shiftList.ToDictionary(x => x.shift_id, x => x);
			context.Shifts.AddRange(shifts.Values);
			context.SaveChanges();

			// seed Barber data
			//List<Barber> barberList = new List<Barber>() {
			//	new Barber { barber_id=1, barber_name="John",barber_email="john@gmail.com", barber_contact="236-789-1234"},
			//};


			List<Barber> barberList = new List<Barber>()  {
				new Barber { barber_id=1, barber_name = "John",barber_email = "john@gmail.com", barber_contact = "236-789-1234" },
				new Barber { barber_id=2, barber_name = "Bill",barber_email = "jbkelling1@discuz.net", barber_contact = "488-681-5180" },
				new Barber { barber_id=3, barber_name = "Tudor",barber_email = "tharris2@over-blog.com", barber_contact = "869-743-7544" },
				new Barber { barber_id=4, barber_name = "Lucais",barber_email = "lparcell3@skyrock.com", barber_contact = "632-446-9773" },
				new Barber { barber_id=5, barber_name = "Rheta",barber_email = "rdundredge4@linkedin.com", barber_contact = "134-581-1712" },
				new Barber { barber_id=6, barber_name = "Emmalynn",barber_email = "eedinburough5@github.com", barber_contact = "566-643-4531" },
				new Barber { barber_id=7, barber_name = "Iorgos",barber_email = "imundell6@deliciousdays.com", barber_contact = "526-643-4331" },
				new Barber { barber_id=8, barber_name = "Abbot",barber_email = "aswatton7@squarespace.com", barber_contact = "223-402-8437" },
				new Barber { barber_id=9, barber_name = "Augustus",barber_email = "ahedan8@vistaprint.com", barber_contact = "767-738-5395" },
				new Barber { barber_id=10, barber_name = "Kingsley",barber_email = "kwarters9@yelp.com", barber_contact = "346-838-8774" },
				new Barber { barber_id=11, barber_name = "Florinda",barber_email = "jstacka@google.com", barber_contact = "574-865-0888" },
				new Barber { barber_id=12, barber_name = "Bryon",barber_email = "rfreakq@goo.com'", barber_contact = "767-221-3642" },
				new Barber { barber_id=13, barber_name = "Inna",barber_email = "eesbergers@acquirethisname.com", barber_contact = "273-481-5406" },
				new Barber { barber_id=14, barber_name = "Winnie",barber_email = "llehuquetu@angelfire.com", barber_contact = "371-785-7410" },
				new Barber { barber_id=15, barber_name = "Rod",barber_email = "edeehanw@tamu.edu", barber_contact = "837-564-7153" }

			};




			// use a dictionary to set the barber_id fields in Barber_shifts

			Dictionary<int, Barber> barbers = barberList.ToDictionary(x => x.barber_id, x => x);

			context.Barbers.AddRange(barbers.Values);
			context.SaveChanges();

			// seed Shifts data
			List<Barber_shifts> barber_shiftsList = new List<Barber_shifts>()  {
					new Barber_shifts{barber_id=1,shift_id=1,price=15,Barber=barbers[1],Shift=shifts[1]}
					//new Barber_shifts{barber_id=2,shift_id=1,price=25,Barber=barbers[1],Shift=shifts[1]},
					//new Barber_shifts{barber_id=1,shift_id=1,price=35,Barber=barbers[1],Shift=shifts[1]},
					//new Barber_shifts{barber_id=2,shift_id=1,price=15,Barber=barbers[1],Shift=shifts[1]},
					//new Barber_shifts{barber_id=3,shift_id=1,price=25,Barber=barbers[1],Shift=shifts[1]},
			};

			// use a dictionary to set the barber_id and shift_id fields in Barber_Avail

			Dictionary<int, Barber_shifts> barber_shifts = barber_shiftsList.ToDictionary(x => x.barber_id, x => x);
			//Dictionary<int, Barber_shifts> barber_shifts = barber_shiftsList.ToDictionary(x => x.shift_id, x => x); since barber_id=shift_id in inserted records
			context.Barber_shifts.AddRange(barber_shifts.Values);
			context.SaveChanges();

			// seed Shops data
			List<Shop> shopList = new List<Shop>()  {
					new Shop{shop_id=1,shop_name="Deckow Bogan and Hammes", location="3943 Tennessee Junction", postal_code="568 92"},
			};

			// use a dictionary to set the shop_id fields in Barber_Avail
			Dictionary<int, Shop> shops = shopList.ToDictionary(x => x.shop_id, x => x);
			context.Shops.AddRange(shops.Values);
			context.SaveChanges();


			// seed Haircut data
			List<Haircut> haircutList = new List<Haircut>()  {
					new Haircut{ haircut_id=1,picture="a",description="undercut", price=12},
			};

			// use a dictionary to set the haircut_id fields in Appointments
			Dictionary<int, Haircut> haircuts = haircutList.ToDictionary(x => x.haircut_id, x => x);
			context.Haircuts.AddRange(haircuts.Values);
			context.SaveChanges();

			// seed Haircut data
			List<User> userList = new List<User>()  {
					new User{user_id=1,user_name="Maribelle Gurton",user_email="mgurton0@cisco.com",user_contact="592-244-8780"},
			};

			// use a dictionary to set the user_id fields in Appointments
			Dictionary<int, User> users = userList.ToDictionary(x => x.user_id, x => x);
			context.Users.AddRange(users.Values);
			context.SaveChanges();

			// seed Status data
			List<Status> statusList = new List<Status>()  {
					new Status{status_id="ACCEPTED",description="The request is accepted"},
					new Status{status_id="FULLFILLED",description="The request is fullfilled"},
					new Status{status_id="PENDING",description="The request is pending and yet to be processed"},
					new Status{status_id="REJECTED",description="The request is rejected"}
			};

			// use a dictionary to set the status_id fields in Appointments
			Dictionary<string, Status> status = statusList.ToDictionary(x => x.status_id, x => x);
			context.Status.AddRange(status.Values);
			context.SaveChanges();


			// seed Barber_Avail data
			List<Barber_Avail> barber_AvailList = new List<Barber_Avail>()  {
					new Barber_Avail{barberAvail_id=1,shop_id=1,barber_id=1,shift_id=1,Shop=shops[1],Barber_shifts=barber_shifts[1]},
					/*new Barber_Avail{barberAvail_id=2,shop_id=1,barber_id=2,shift_id=2,Shop=shops[1],Barber_shifts=barber_shifts[2]},
					new Barber_Avail{barberAvail_id=3,shop_id=1,barber_id=3,shift_id=3,Shop=shops[1],Barber_shifts=barber_shifts[3]},
					new Barber_Avail{barberAvail_id=4,shop_id=2,barber_id=4,shift_id=4,Shop=shops[2],Barber_shifts=barber_shifts[4]},
					new Barber_Avail{barberAvail_id=5,shop_id=2,barber_id=5,shift_id=5,Shop=shops[2],Barber_shifts=barber_shifts[5]},
					new Barber_Avail{barberAvail_id=6,shop_id=2,barber_id=1,shift_id=1,Shop=shops[2],Barber_shifts=barber_shifts[1]},
					new Barber_Avail{barberAvail_id=7,shop_id=3,barber_id=2,shift_id=2,Shop=shops[3],Barber_shifts=barber_shifts[2]},
					new Barber_Avail{barberAvail_id=8,shop_id=3,barber_id=3,shift_id=3,Shop=shops[3],Barber_shifts=barber_shifts[3]},
					new Barber_Avail{barberAvail_id=9,shop_id=3,barber_id=4,shift_id=4,Shop=shops[3],Barber_shifts=barber_shifts[4]},
					new Barber_Avail{barberAvail_id=10,shop_id=4,barber_id=5,shift_id=5,Shop=shops[4],Barber_shifts=barber_shifts[5]},
					new Barber_Avail{barberAvail_id=11,shop_id=4,barber_id=1,shift_id=1,Shop=shops[4],Barber_shifts=barber_shifts[1]},
					new Barber_Avail{barberAvail_id=12,shop_id=4,barber_id=2,shift_id=2,Shop=shops[4],Barber_shifts=barber_shifts[2]},
					new Barber_Avail{barberAvail_id=13,shop_id=5,barber_id=3,shift_id=3,Shop=shops[5],Barber_shifts=barber_shifts[3]},
					new Barber_Avail{barberAvail_id=14,shop_id=5,barber_id=4,shift_id=4,Shop=shops[5],Barber_shifts=barber_shifts[4]},
					new Barber_Avail{barberAvail_id=15,shop_id=5,barber_id=5,shift_id=5,Shop=shops[5],Barber_shifts=barber_shifts[5]}*/
			};

			// use a dictionary to set the barberAvail_id fields in Appointments
			Dictionary<int, Barber_Avail> barber_Avail = barber_AvailList.ToDictionary(x => x.barberAvail_id, x => x);
			context.Barber_Avail.AddRange(barber_Avail.Values);
			context.SaveChanges();


			// seed Haircut data
			List<Appointment> appointmentList = new List<Appointment>()  {
					new Appointment{appointment_id=1,barberAvail_id=1,haircut_id=1,user_id=1,appointment_time=TimeSpan.Parse("14:00:00"),status_id="PENDING",payment_status="N",review=0,Barber_Avail=barber_Avail[1],Haircut=haircuts[1],User=users[1]},
					/*new Appointment{appointment_id=2,barberAvail_id=4,haircut_id=2,user_id=3,appointment_time=TimeSpan.Parse("11:30:00"),status_id="PENDING",payment_status="N",review=0,Barber_Avail=barber_Avail[1],Haircut=haircuts[1],User=users[1]},
					new Appointment{appointment_id=3,barberAvail_id=5,haircut_id=3,user_id=1,appointment_time=TimeSpan.Parse("13:30:00"),status_id="ACCEPTED",payment_status="N",review=0,Barber_Avail=barber_Avail[1],Haircut=haircuts[1],User=users[1]},
					new Appointment{appointment_id=4,barberAvail_id=8,haircut_id=4,user_id=4,appointment_time=TimeSpan.Parse("14:15:00"),status_id="REJECTED",payment_status="N",review=0,Barber_Avail=barber_Avail[1],Haircut=haircuts[1],User=users[1]}*/
			};

		}
    }
}
