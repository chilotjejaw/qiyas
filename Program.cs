string? region =null;
Console.WriteLine(region?.ToUpper());
string? upperRegion =region?.ToUpper();
Console.WriteLine($"upperregion:{upperRegion}");
string displayRegion = region ?? "Unassigned";
Console.WriteLine($"Region (coalesced): {displayRegion}");
region ??= "Addis Ababa";
Console.WriteLine($"Region (assigned): {region}");
//Step 3 —DeclareYour First TMS Variables
string studentName = "Abeba";
string studentId = "STU-001";
int enrollmentCount = 3;
decimal grantAmount = 1999.99m; // 'm' suffix marks a decimal literal
DateTime enrolledAt = DateTime.UtcNow;
string? campusRegion = null;
Console.WriteLine($"Student: {studentName} ({studentId})");
Console.WriteLine($"Courses: {enrollmentCount}");
Console.WriteLine($"Grant: {grantAmount:F2}");
Console.WriteLine($"Enrolled: {enrolledAt:yyyy-MM-dd}");
Console.WriteLine($"Campus: {campusRegion ?? "Not assigned"}");
// Legacy implementation — the bug that caused the audit failure
decimal grantPerStudent = 1999.99m;
decimal numberOfStudents = 100_000m;

decimal totalAllocation = grantPerStudent * numberOfStudents;

Console.WriteLine($"Grant per student: {grantPerStudent:C2}");
Console.WriteLine($"Number of students: {numberOfStudents:N0}");
Console.WriteLine($"Total allocated: {totalAllocation:N2}");
// Legacy implementation — what the logging service did to the data
//test enrolment record
var enrollment =
    new EnrollmentRecord(
        "STU-001",
        "CS-401",
        DateTime.UtcNow);

Console.WriteLine(enrollment);

var corrected =
    enrollment with { CourseCode = "CS-402" };

Console.WriteLine(corrected);

var duplicate =
    new EnrollmentRecord(
        "STU-001",
        "CS-401",
        enrollment.EnrolledAt);

Console.WriteLine($"Same data? {enrollment == duplicate}");}