using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FamilyTreeApp._TestDbContext;
using Microsoft.EntityFrameworkCore;

namespace FamilyTreeApp._Model
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<person>().HasData(
                new person { personID = 1, firstName = "Harry", lastName = "Potter", Gender = gender.male, Status = status.married },
                new person { personID = 2, firstName = "Ginevra", lastName = "Weasley", Gender = gender.female, Status = status.married},
                new person { personID = 3, firstName = "James", lastName = "Potter", Gender = gender.male, Status = status.married },
                new person { personID = 4, firstName = "Lily", lastName = "Evans", Gender = gender.female, Status = status.married },
                new person { personID = 5, firstName = "James", lastName = "Potter", Gender = gender.male, Status = status.single },
                new person { personID = 6, firstName = "Albus", lastName = "Potter", Gender = gender.male, Status = status.single },
                new person { personID = 7, firstName = "Luna", lastName = "Potter", Gender = gender.female, Status = status.single },
                new person { personID = 8, firstName = "Petunia", lastName = "Evans", Gender = gender.female, Status = status.married },
                new person { personID = 9, firstName = "Vernon", lastName = "Dursley", Gender = gender.male, Status = status.married },
                new person { personID = 10, firstName = "Dudley", lastName = "Dursley", Gender = gender.male, Status = status.single },
                new person { personID = 11, firstName = "Euphemia", lastName = "", Gender = gender.female, Status = status.unknown },
                new person { personID = 12, firstName = "Fleamount", lastName = "Potter", Gender = gender.male, Status = status.married },
                new person { personID = 13, firstName = "Molly", lastName = "Prewett", Gender = gender.female, Status = status.married },
                new person { personID = 14, firstName = "Arthur", lastName = "Weasley", Gender = gender.male, Status = status.married },
                new person { personID = 15, firstName = "Ronald", lastName = "Weasley", Gender = gender.male, Status = status.single},
                new person { personID = 16, firstName = "George", lastName = "Weasley", Gender = gender.male, Status = status.unknown },
                new person { personID = 17, firstName = "Fred", lastName = "Weasley", Gender = gender.male, Status = status.unknown },
                new person { personID = 18, firstName = "Percival", lastName = "Weasley", Gender = gender.male, Status = status.unknown },
                new person { personID = 19, firstName = "Charile", lastName = "Weasley", Gender = gender.male, Status = status.unknown},
                new person { personID = 20, firstName = "Bill", lastName = "Weasley", Gender = gender.male, Status = status.unknown },
                new person { personID = 21, firstName = "Septimus", lastName = "Weasley", Gender = gender.male, Status = status.married },
                new person { personID = 22, firstName = "Cedrella", lastName = "Blach", Gender = gender.female, Status = status.married },
                new person { personID = 23, firstName = "Bilius", lastName = "Weasley", Gender = gender.female, Status = status.unknown },
                new person { personID = 24, firstName = "Fleur", lastName = "Delacour", Gender = gender.female, Status = status.married },
                new person { personID = 25, firstName = "Victorie", lastName = "Weasley", Gender = gender.female, Status = status.unknown },
                new person { personID = 26, firstName = "Dominique", lastName = "Weasley", Gender = gender.female, Status = status.unknown },
                new person { personID = 27, firstName = "Louis", lastName = "Weasley", Gender = gender.male, Status = status.unknown }
                );


            modelBuilder.Entity<spouse>().HasData(
                new spouse { spouseID = 1, spouseFirstName = "Harry", spouseLastName = "Potter", personIDFK = 2 },
                new spouse { spouseID = 2, spouseFirstName = "Ginevra", spouseLastName = "Weasley", personIDFK = 1 },
                new spouse { spouseID = 3, spouseFirstName = "James", spouseLastName = "Potter", personIDFK = 4 },
                new spouse { spouseID = 4, spouseFirstName = "Lily", spouseLastName = "Evans", personIDFK = 3 },
                new spouse { spouseID = 5, spouseFirstName = "Petunia", spouseLastName = "Evans", personIDFK = 9 },
                new spouse { spouseID = 6, spouseFirstName = "Vernon", spouseLastName = "Dursley", personIDFK = 8 },
                new spouse { spouseID = 7, spouseFirstName = "Euphemia", spouseLastName = "", personIDFK = 12 },
                new spouse { spouseID = 8, spouseFirstName = "Fleamont", spouseLastName = "Potter", personIDFK = 11 },
                new spouse { spouseID = 9, spouseFirstName = "Molly", spouseLastName = "Prewett", personIDFK = 14 },
                new spouse { spouseID = 10, spouseFirstName = "Arthur", spouseLastName = "Weasley", personIDFK = 13 },
                new spouse { spouseID = 11, spouseFirstName = "Septimus", spouseLastName = "Weasley", personIDFK = 22 },
                new spouse { spouseID = 12, spouseFirstName = "Cedrella", spouseLastName = "Black", personIDFK = 21 },
                new spouse { spouseID = 13, spouseFirstName = "bill", spouseLastName = "Weasley", personIDFK = 24 },
                new spouse { spouseID = 14, spouseFirstName = "Fleur", spouseLastName = "Delacour", personIDFK = 20 }
                );

            
            modelBuilder.Entity<father>().HasData(
                new father {fatherID = 1,fatherFirstName = "Harry", fatherLastName = "Potter", personIDFK = 5 },
                new father { fatherID = 2, fatherFirstName = "Harry", fatherLastName = "Potter", personIDFK = 6 },
                new father { fatherID = 3, fatherFirstName = "Harry", fatherLastName = "Potter", personIDFK = 7 }, 
                new father { fatherID = 4, fatherFirstName = "James", fatherLastName = "Potter", personIDFK = 1 },
                new father { fatherID = 5, fatherFirstName = "Fleamont", fatherLastName = "Potter", personIDFK = 3 },
                new father { fatherID = 6, fatherFirstName = "Vemon", fatherLastName = "Dursley", personIDFK = 10 },
                new father { fatherID = 7, fatherFirstName = "Arthur", fatherLastName = "Weasley", personIDFK = 2 },
                new father { fatherID = 8, fatherFirstName = "Arthur", fatherLastName = "Weasley", personIDFK = 15 },
                new father { fatherID = 9, fatherFirstName = "Arthur", fatherLastName = "Weasley", personIDFK = 16 },
                new father { fatherID = 10, fatherFirstName = "Arthur", fatherLastName = "Weasley", personIDFK = 17 },
                new father { fatherID = 11, fatherFirstName = "Arthur", fatherLastName = "Weasley", personIDFK = 18 },
                new father { fatherID = 12, fatherFirstName = "Arthur", fatherLastName = "Weasley", personIDFK = 19 },
                new father { fatherID = 13, fatherFirstName = "Arthur", fatherLastName = "Weasley", personIDFK = 20 },
                new father { fatherID = 14, fatherFirstName = "Bill", fatherLastName = "Weasley", personIDFK = 25 },
                new father { fatherID = 15, fatherFirstName = "Bill", fatherLastName = "Weasley", personIDFK = 26 },
                new father { fatherID = 16, fatherFirstName = "Bill", fatherLastName = "Weasley", personIDFK = 27 },
                new father { fatherID = 17, fatherFirstName = "Septimus", fatherLastName = "Weasley", personIDFK = 14 }
                );
            


            modelBuilder.Entity<mother>().HasData(
                new mother { motherID = 1, motherFirstName = "Ginevra", motherLastName = "Weasley", personIDFK = 5 },
                new mother { motherID = 2, motherFirstName = "Ginevra", motherLastName = "Weasley", personIDFK = 6 },
                new mother { motherID = 3, motherFirstName = "Ginevra", motherLastName = "Weasley", personIDFK = 7 },
                new mother { motherID = 4, motherFirstName = "Lily", motherLastName = "Potter", personIDFK = 1 },
                new mother { motherID = 5, motherFirstName = "Petunia", motherLastName = "Evans", personIDFK = 10 },
                new mother { motherID = 6, motherFirstName = "Euphemia", motherLastName = "", personIDFK = 11 },
                new mother { motherID = 7, motherFirstName = "Molly", motherLastName = "Prewett", personIDFK = 2 },
                new mother { motherID = 8, motherFirstName = "Molly", motherLastName = "Prewett", personIDFK = 15 },
                new mother { motherID = 9, motherFirstName = "Molly", motherLastName = "Prewett", personIDFK = 16 },
                new mother { motherID = 10, motherFirstName = "Molly", motherLastName = "Prewett", personIDFK = 17 },
                new mother { motherID = 11, motherFirstName = "Molly", motherLastName = "Prewett", personIDFK = 18 },
                new mother { motherID = 12, motherFirstName = "Molly", motherLastName = "Prewett", personIDFK = 19 },
                new mother { motherID = 13, motherFirstName = "Molly", motherLastName = "Prewett", personIDFK = 20 },
                new mother { motherID = 14, motherFirstName = "Fleur", motherLastName = "Delacour", personIDFK = 25 },
                new mother { motherID = 15, motherFirstName = "Fleur", motherLastName = "Delacour", personIDFK = 26 },
                new mother { motherID = 16, motherFirstName = "Fleur", motherLastName = "Delacour", personIDFK = 27 }

                );

            
            modelBuilder.Entity<children>().HasData(
                new children { childID = 1, childFirstName = "Harry", childLastName = "Potter", personIDFK = 3 },
                new children { childID = 2, childFirstName = "Harry", childLastName = "Potter", personIDFK = 4 },
                new children { childID = 3, childFirstName = "Ginevra", childLastName = "Weasley", personIDFK = 13 },
                new children { childID = 4, childFirstName = "Ginevra", childLastName = "Weasley", personIDFK = 14 },
                 new children { childID = 5, childFirstName = "James", childLastName = "Potter", personIDFK = 11 },
                new children { childID = 6, childFirstName = "James", childLastName = "Potter", personIDFK = 12 },
                new children { childID = 7, childFirstName = "James", childLastName = "Potter", personIDFK = 1 },
                new children { childID = 8, childFirstName = "James", childLastName = "Potter", personIDFK = 2 },
                new children { childID = 9, childFirstName = "Albus", childLastName = "Potter", personIDFK = 1 },
                new children { childID = 10, childFirstName = "Albus", childLastName = "Potter", personIDFK = 2 },
                new children { childID = 11, childFirstName = "Luna", childLastName = "Potter", personIDFK = 1 },
                new children { childID = 12, childFirstName = "Luna", childLastName = "Potter", personIDFK = 2 },
                new children { childID = 13, childFirstName = "Ronald", childLastName = "Weasley", personIDFK = 13 },
                new children { childID = 14, childFirstName = "Ronald", childLastName = "Weasley", personIDFK = 14 },
                new children { childID = 15, childFirstName = "George", childLastName = "Weasley", personIDFK = 13 },
                new children { childID = 16, childFirstName = "George", childLastName = "Weasley", personIDFK = 14 },
                new children { childID = 17, childFirstName = "Fred", childLastName = "Weasley", personIDFK = 13 },
                new children { childID = 18, childFirstName = "Fred", childLastName = "Weasley", personIDFK = 14 },
                new children { childID = 19, childFirstName = "Percival", childLastName = "Weasley", personIDFK = 13 },
                new children { childID = 20, childFirstName = "Percival", childLastName = "Weasley", personIDFK = 14 },
                new children { childID = 21, childFirstName = "Charlie", childLastName = "Weasley", personIDFK = 13 },
                new children { childID = 22, childFirstName = "Charlie", childLastName = "Weasley", personIDFK = 14 },
                new children { childID = 23, childFirstName = "Bill", childLastName = "Weasley", personIDFK = 13 },
                new children { childID = 24, childFirstName = "Bill", childLastName = "Weasley", personIDFK = 14 },
                new children { childID = 25, childFirstName = "Victoire", childLastName = "Weasley", personIDFK = 20 },
                new children { childID = 26, childFirstName = "Victoire", childLastName = "Weasley", personIDFK = 24 },
                new children { childID = 27, childFirstName = "Dominique", childLastName = "Weasley", personIDFK = 20 },
                new children { childID = 28, childFirstName = "Dominique", childLastName = "Weasley", personIDFK = 24 },
                new children { childID = 29, childFirstName = "Louis", childLastName = "Weasley", personIDFK = 20 },
                new children { childID = 30, childFirstName = "Louis", childLastName = "Weasley", personIDFK = 24 },
                new children { childID = 31, childFirstName = "Arthur", childLastName = "Weasley", personIDFK = 21 },
                new children { childID = 32, childFirstName = "Arthur", childLastName = "Weasley", personIDFK = 22 },
                 new children { childID = 33, childFirstName = "Dudley", childLastName = "Dursley", personIDFK = 8 },
                new children { childID = 34, childFirstName = "Dudley", childLastName = "Dursley", personIDFK = 9 }
                );
            

            modelBuilder.Entity<sibling>().HasData(
                new sibling { siblingID = 1, siblingFirstName = "Lily", siblingLastName = "Evans", personIDFK = 8 },
                new sibling { siblingID = 2, siblingFirstName = "James", siblingLastName = "Potter", personIDFK = 6 },
                new sibling { siblingID = 3, siblingFirstName = "James", siblingLastName = "Potter", personIDFK = 7 },
                new sibling { siblingID = 4, siblingFirstName = "Albus", siblingLastName = "Potter", personIDFK = 5 },
                new sibling { siblingID = 5, siblingFirstName = "Albus", siblingLastName = "Potter", personIDFK = 7 },
                new sibling { siblingID = 6, siblingFirstName = "Luna", siblingLastName = "Potter", personIDFK = 5 },
                new sibling { siblingID = 7, siblingFirstName = "Luna", siblingLastName = "Potter", personIDFK = 6 },
                new sibling { siblingID = 8, siblingFirstName = "Petuna", siblingLastName = "Evans", personIDFK = 4 },
                new sibling { siblingID = 9, siblingFirstName = "Ginevra", siblingLastName = "Weasley", personIDFK = 15 },
                new sibling { siblingID = 10, siblingFirstName = "Ginevra", siblingLastName = "Weasley", personIDFK = 16 },
                new sibling { siblingID = 11, siblingFirstName = "Ginevra", siblingLastName = "Weasley", personIDFK = 17 },
                new sibling { siblingID = 12, siblingFirstName = "Ginevra", siblingLastName = "Weasley", personIDFK = 18 },
                new sibling { siblingID = 13, siblingFirstName = "Ginevra", siblingLastName = "Weasley", personIDFK = 19 },
                new sibling { siblingID = 14, siblingFirstName = "Ginevra", siblingLastName = "Weasley", personIDFK = 20 },
                new sibling { siblingID = 15, siblingFirstName = "Ronald", siblingLastName = "Weasley", personIDFK = 2 },
                new sibling { siblingID = 16, siblingFirstName = "Ronald", siblingLastName = "Weasley", personIDFK = 16 },
                new sibling { siblingID = 17, siblingFirstName = "Ronald", siblingLastName = "Weasley", personIDFK = 17 },
                new sibling { siblingID = 18, siblingFirstName = "Ronald", siblingLastName = "Weasley", personIDFK = 18 },
                new sibling { siblingID = 19, siblingFirstName = "Ronald", siblingLastName = "Weasley", personIDFK = 19 },
                new sibling { siblingID = 20, siblingFirstName = "Ronald", siblingLastName = "Weasley", personIDFK = 20 },
                new sibling { siblingID = 21, siblingFirstName = "George", siblingLastName = "Weasley", personIDFK = 2 },
                new sibling { siblingID = 22, siblingFirstName = "George", siblingLastName = "Weasley", personIDFK = 15 },
                new sibling { siblingID = 23, siblingFirstName = "George", siblingLastName = "Weasley", personIDFK = 17 },
                new sibling { siblingID = 24, siblingFirstName = "George", siblingLastName = "Weasley", personIDFK = 18 },
                new sibling { siblingID = 25, siblingFirstName = "George", siblingLastName = "Weasley", personIDFK = 19 },
                new sibling { siblingID = 26, siblingFirstName = "George", siblingLastName = "Weasley", personIDFK = 20 },
                new sibling { siblingID = 27, siblingFirstName = "Fred", siblingLastName = "Weasley", personIDFK = 2 },
                new sibling { siblingID = 28, siblingFirstName = "Fred", siblingLastName = "Weasley", personIDFK = 15 },
                new sibling { siblingID = 29, siblingFirstName = "Fred", siblingLastName = "Weasley", personIDFK = 16 },
                new sibling { siblingID = 30, siblingFirstName = "Fred", siblingLastName = "Weasley", personIDFK = 18 },
                new sibling { siblingID = 31, siblingFirstName = "Fred", siblingLastName = "Weasley", personIDFK = 19 },
                new sibling { siblingID = 32, siblingFirstName = "Fred", siblingLastName = "Weasley", personIDFK = 20 },
                new sibling { siblingID = 33, siblingFirstName = "Percival", siblingLastName = "Weasley", personIDFK = 2 },
                new sibling { siblingID = 34, siblingFirstName = "Percival", siblingLastName = "Weasley", personIDFK = 15 },
                new sibling { siblingID = 35, siblingFirstName = "Percival", siblingLastName = "Weasley", personIDFK = 16 },
                new sibling { siblingID = 36, siblingFirstName = "Percival", siblingLastName = "Weasley", personIDFK = 17 },
                new sibling { siblingID = 37, siblingFirstName = "Percival", siblingLastName = "Weasley", personIDFK = 19 },
                new sibling { siblingID = 38, siblingFirstName = "Percival", siblingLastName = "Weasley", personIDFK = 20 },
                new sibling { siblingID = 39, siblingFirstName = "Charile", siblingLastName = "Weasley", personIDFK = 2 },
                new sibling { siblingID = 40, siblingFirstName = "Charile", siblingLastName = "Weasley", personIDFK = 15 },
                new sibling { siblingID = 41, siblingFirstName = "Charile", siblingLastName = "Weasley", personIDFK = 16 },
                new sibling { siblingID = 42, siblingFirstName = "Charile", siblingLastName = "Weasley", personIDFK = 17 },
                new sibling { siblingID = 43, siblingFirstName = "Charile", siblingLastName = "Weasley", personIDFK = 18 },
                new sibling { siblingID = 44, siblingFirstName = "Charile", siblingLastName = "Weasley", personIDFK = 20 },
                new sibling { siblingID = 45, siblingFirstName = "Bill", siblingLastName = "Weasley", personIDFK = 2 },
                new sibling { siblingID = 46, siblingFirstName = "Bill", siblingLastName = "Weasley", personIDFK = 15 },
                new sibling { siblingID = 47, siblingFirstName = "Bill", siblingLastName = "Weasley", personIDFK = 16 },
                new sibling { siblingID = 48, siblingFirstName = "Bill", siblingLastName = "Weasley", personIDFK = 17 },
                new sibling { siblingID = 49, siblingFirstName = "Bill", siblingLastName = "Weasley", personIDFK = 18 },
                new sibling { siblingID = 50, siblingFirstName = "Bill", siblingLastName = "Weasley", personIDFK = 19 },
                new sibling { siblingID = 51, siblingFirstName = "Arthur", siblingLastName = "Weasley", personIDFK = 23 },
                new sibling { siblingID = 52, siblingFirstName = "Bilius", siblingLastName = "Weasley", personIDFK = 14 },
                new sibling { siblingID = 53, siblingFirstName = "Victoire", siblingLastName = "Weasley", personIDFK = 26 },
                new sibling { siblingID = 54, siblingFirstName = "Victoire", siblingLastName = "Weasley", personIDFK = 27 },
                new sibling { siblingID = 55, siblingFirstName = "Dominique", siblingLastName = "Weasley", personIDFK = 25 },
                new sibling { siblingID = 56, siblingFirstName = "Dominique", siblingLastName = "Weasley", personIDFK = 27 },
                new sibling { siblingID = 57, siblingFirstName = "Louis", siblingLastName = "Weasley", personIDFK = 25 },
                new sibling { siblingID = 58, siblingFirstName = "Louis", siblingLastName = "Weasley", personIDFK = 26 }
                );


            modelBuilder.Entity<grandFather>().HasData(
                new grandFather { grandFatherID = 1, grandFatherFirstName = "Flearnont", grandFatherLastName = "Potter", personIDFK =1},
                new grandFather { grandFatherID = 2, grandFatherFirstName = "James", grandFatherLastName = "POtter", personIDFK = 5 },
                new grandFather { grandFatherID = 3, grandFatherFirstName = "James", grandFatherLastName = "POtter", personIDFK = 6 },
                new grandFather { grandFatherID = 4, grandFatherFirstName = "James", grandFatherLastName = "POtter", personIDFK = 7 },
                new grandFather { grandFatherID = 5, grandFatherFirstName = "Arthur", grandFatherLastName = "Weasley", personIDFK = 5 },
                new grandFather { grandFatherID = 6, grandFatherFirstName = "Arthur", grandFatherLastName = "Weasley", personIDFK = 6 },
                new grandFather { grandFatherID = 7, grandFatherFirstName = "Arthur", grandFatherLastName = "Weasley", personIDFK = 7 },
                new grandFather { grandFatherID = 8, grandFatherFirstName = "Arthur", grandFatherLastName = "Weasley", personIDFK = 25 },
                new grandFather { grandFatherID = 9, grandFatherFirstName = "Arthur", grandFatherLastName = "Weasley", personIDFK = 26 },
                new grandFather { grandFatherID = 10, grandFatherFirstName = "Arthur", grandFatherLastName = "Weasley", personIDFK = 27 },
                new grandFather { grandFatherID = 11, grandFatherFirstName = "Arthur", grandFatherLastName = "Weasley", personIDFK = 2 },
                new grandFather { grandFatherID = 12, grandFatherFirstName = "Arthur", grandFatherLastName = "Weasley", personIDFK = 2 },
                new grandFather { grandFatherID = 13, grandFatherFirstName = "Seplimus", grandFatherLastName = "Weasley", personIDFK = 2 },
                new grandFather { grandFatherID = 14, grandFatherFirstName = "Seplimus", grandFatherLastName = "Weasley", personIDFK = 15 },
                new grandFather { grandFatherID = 15, grandFatherFirstName = "Seplimus", grandFatherLastName = "Weasley", personIDFK = 16 },
                new grandFather { grandFatherID = 16, grandFatherFirstName = "Seplimus", grandFatherLastName = "Weasley", personIDFK = 17 },
                new grandFather { grandFatherID = 17, grandFatherFirstName = "Seplimus", grandFatherLastName = "Weasley", personIDFK = 18 },
                new grandFather { grandFatherID = 18, grandFatherFirstName = "Seplimus", grandFatherLastName = "Weasley", personIDFK = 19 },
                new grandFather { grandFatherID = 19, grandFatherFirstName = "Seplimus", grandFatherLastName = "Weasley", personIDFK = 20 }

               
                );


            modelBuilder.Entity<grandMother>().HasData(
                new grandMother { grandMotherID = 1, grandMotherFirstName = "Euphernia", grandMotherLastName = "", personIDFK =  1},
                new grandMother { grandMotherID = 2, grandMotherFirstName = "Lily", grandMotherLastName = "Evans", personIDFK = 5 },
                new grandMother { grandMotherID = 3, grandMotherFirstName = "Lily", grandMotherLastName = "Evans", personIDFK = 6 },
                new grandMother { grandMotherID = 4, grandMotherFirstName = "Lily", grandMotherLastName = "Evans", personIDFK = 7 },
                new grandMother { grandMotherID = 5, grandMotherFirstName = "Molly", grandMotherLastName = "Prewett", personIDFK = 5 },
                new grandMother { grandMotherID = 6, grandMotherFirstName = "Molly", grandMotherLastName = "Prewett", personIDFK = 6 },
                new grandMother { grandMotherID = 7, grandMotherFirstName = "Molly", grandMotherLastName = "Prewett", personIDFK = 7 },
                new grandMother { grandMotherID = 8, grandMotherFirstName = "Molly", grandMotherLastName = "Prewett", personIDFK = 25 },
                new grandMother { grandMotherID = 9, grandMotherFirstName = "Molly", grandMotherLastName = "Prewett", personIDFK = 26 },
                new grandMother { grandMotherID = 10, grandMotherFirstName = "Molly", grandMotherLastName = "Prewett", personIDFK = 27 },
                new grandMother { grandMotherID = 11, grandMotherFirstName = "Cidrella", grandMotherLastName = "Black", personIDFK = 2 },
                new grandMother { grandMotherID = 12, grandMotherFirstName = "Cidrella", grandMotherLastName = "Black", personIDFK = 15 },
                new grandMother { grandMotherID = 13, grandMotherFirstName = "Cidrella", grandMotherLastName = "Black", personIDFK = 16 },
                new grandMother { grandMotherID = 14, grandMotherFirstName = "Cidrella", grandMotherLastName = "Black", personIDFK = 17 },
                new grandMother { grandMotherID = 15, grandMotherFirstName = "Cidrella", grandMotherLastName = "Black", personIDFK = 18 },
                new grandMother { grandMotherID = 16, grandMotherFirstName = "Cidrella", grandMotherLastName = "Black", personIDFK = 19 },
                new grandMother { grandMotherID = 17, grandMotherFirstName = "Cidrella", grandMotherLastName = "Black", personIDFK = 20 }

                );


            modelBuilder.Entity<aunt>().HasData(
                new aunt { auntID = 1, auntFirstName = "Petunia", auntLastName = "Evans", personIDFK = 1},
                new aunt { auntID = 2, auntFirstName = "Lily", auntLastName = "Evans", personIDFK = 10 },
                new aunt { auntID = 3, auntFirstName = "Fleur", auntLastName = "Delacour", personIDFK = 5 },
                new aunt { auntID = 4, auntFirstName = "Fleur", auntLastName = "Delacour", personIDFK = 6},
                new aunt { auntID = 5, auntFirstName = "Fleur", auntLastName = "Delacour", personIDFK = 7 },
                new aunt { auntID = 6, auntFirstName = "Ginevra", auntLastName = "Weasley", personIDFK = 25 },
                new aunt { auntID = 7, auntFirstName = "Ginevra", auntLastName = "Weasley", personIDFK = 26},
                new aunt { auntID = 8, auntFirstName = "Ginevra", auntLastName = "Weasley", personIDFK = 27 }
                );


            modelBuilder.Entity<uncle>().HasData(
                new uncle { uncleID = 1, uncleFirstName = "Vernon", uncleLastName = "Dursley", personIDFK = 1 },
                new uncle { uncleID = 2, uncleFirstName = "James", uncleLastName = "Potter", personIDFK = 10},
                new uncle { uncleID = 3, uncleFirstName = "Ronald", uncleLastName = "Weasley", personIDFK = 5},
                new uncle { uncleID = 4, uncleFirstName = "Ronald", uncleLastName = "Weasley", personIDFK = 6 },
                new uncle { uncleID = 5, uncleFirstName = "Ronald", uncleLastName = "Weasley", personIDFK = 7 },
                new uncle { uncleID = 6, uncleFirstName = "Ronald", uncleLastName = "Weasley", personIDFK = 25 },
                new uncle { uncleID = 7, uncleFirstName = "Ronald", uncleLastName = "Weasley", personIDFK = 26 },
                new uncle { uncleID = 8, uncleFirstName = "Ronald", uncleLastName = "Weasley", personIDFK = 27 },
                new uncle { uncleID = 9, uncleFirstName = "George", uncleLastName = "Weasley", personIDFK = 5 },
                new uncle { uncleID = 10, uncleFirstName = "George", uncleLastName = "Weasley", personIDFK = 6 },
                new uncle { uncleID = 11, uncleFirstName = "George", uncleLastName = "Weasley", personIDFK = 7 },
                new uncle { uncleID = 12, uncleFirstName = "George", uncleLastName = "Weasley", personIDFK = 25 },
                new uncle { uncleID = 13, uncleFirstName = "George", uncleLastName = "Weasley", personIDFK = 26 },
                new uncle { uncleID = 14, uncleFirstName = "George", uncleLastName = "Weasley", personIDFK = 27 },
                new uncle { uncleID = 15, uncleFirstName = "Percival", uncleLastName = "Weasley", personIDFK = 5 },
                new uncle { uncleID = 16, uncleFirstName = "Percival", uncleLastName = "Weasley", personIDFK = 6 },
                new uncle { uncleID = 17, uncleFirstName = "Percival", uncleLastName = "Weasley", personIDFK = 7 },
                new uncle { uncleID = 18, uncleFirstName = "Percival", uncleLastName = "Weasley", personIDFK = 25 },
                new uncle { uncleID = 19, uncleFirstName = "Percival", uncleLastName = "Weasley", personIDFK = 26 },
                new uncle { uncleID = 20, uncleFirstName = "Percival", uncleLastName = "Weasley", personIDFK = 27 },
                new uncle { uncleID = 21, uncleFirstName = "Charlie", uncleLastName = "Weasley", personIDFK = 5 },
                new uncle { uncleID = 22, uncleFirstName = "Charlie", uncleLastName = "Weasley", personIDFK = 6 },
                new uncle { uncleID = 23, uncleFirstName = "Charlie", uncleLastName = "Weasley", personIDFK = 7 },
                new uncle { uncleID = 24, uncleFirstName = "Charlie", uncleLastName = "Weasley", personIDFK = 25 },
                new uncle { uncleID = 25, uncleFirstName = "Charlie", uncleLastName = "Weasley", personIDFK = 26 },
                new uncle { uncleID = 26, uncleFirstName = "Charlie", uncleLastName = "Weasley", personIDFK = 27 },
                new uncle { uncleID = 27, uncleFirstName = "Bill", uncleLastName = "Weasley", personIDFK = 5 },
                new uncle { uncleID = 28, uncleFirstName = "Bill", uncleLastName = "Weasley", personIDFK = 6 },
                new uncle { uncleID = 29, uncleFirstName = "Bill", uncleLastName = "Weasley", personIDFK = 7 },
                new uncle { uncleID = 30, uncleFirstName = "Harry", uncleLastName = "Potter", personIDFK = 25 },
                new uncle { uncleID = 31, uncleFirstName = "Harry", uncleLastName = "Potter", personIDFK = 26},
                new uncle { uncleID = 32, uncleFirstName = "Harry", uncleLastName = "Potter", personIDFK = 27 },
                new uncle { uncleID = 33, uncleFirstName = "Bilius", uncleLastName = "Weasley", personIDFK = 2 },
                new uncle { uncleID = 34, uncleFirstName = "Bilius", uncleLastName = "Weasley", personIDFK = 15 },
                new uncle { uncleID = 35, uncleFirstName = "Bilius", uncleLastName = "Weasley", personIDFK = 16 },
                new uncle { uncleID = 36, uncleFirstName = "Bilius", uncleLastName = "Weasley", personIDFK = 17 },
                new uncle { uncleID = 37, uncleFirstName = "Bilius", uncleLastName = "Weasley", personIDFK = 18 },
                new uncle { uncleID = 38, uncleFirstName = "Bilius", uncleLastName = "Weasley", personIDFK = 19 },
                new uncle { uncleID = 39, uncleFirstName = "Bilius", uncleLastName = "Weasley", personIDFK = 20 }

                );

            modelBuilder.Entity<cousin>().HasData(
                new cousin { cousinID = 1, cousinFirstName = "James", cousinLastName = "Potter", personIDFK = 10},
                new cousin { cousinID = 2, cousinFirstName = "Albus", cousinLastName = "Potter", personIDFK = 10},
                new cousin { cousinID = 3, cousinFirstName = "Luna", cousinLastName = "Potter", personIDFK = 10},
                new cousin { cousinID = 4, cousinFirstName = "James", cousinLastName = "Potter", personIDFK = 25 },
                new cousin { cousinID = 5, cousinFirstName = "Albus", cousinLastName = "Potter", personIDFK = 25 },
                new cousin { cousinID = 6, cousinFirstName = "Luna", cousinLastName = "Potter", personIDFK = 25 },
                new cousin { cousinID = 7, cousinFirstName = "James", cousinLastName = "Potter", personIDFK = 26 },
                new cousin { cousinID = 8, cousinFirstName = "Albus", cousinLastName = "Potter", personIDFK = 26 },
                new cousin { cousinID = 9, cousinFirstName = "Luna", cousinLastName = "Potter", personIDFK = 26 },
                new cousin { cousinID = 10, cousinFirstName = "James", cousinLastName = "Potter", personIDFK = 27 },
                new cousin { cousinID = 11, cousinFirstName = "Albus", cousinLastName = "Potter", personIDFK = 27 },
                new cousin { cousinID = 12, cousinFirstName = "Luna", cousinLastName = "Potter", personIDFK = 27 },
                new cousin { cousinID = 13, cousinFirstName = "Dudley", cousinLastName = "Dursley", personIDFK = 5 },
                new cousin { cousinID = 14, cousinFirstName = "Dudley", cousinLastName = "Dursley", personIDFK = 6 },
                new cousin { cousinID = 15, cousinFirstName = "Dudley", cousinLastName = "Dursley", personIDFK = 7 },
                new cousin { cousinID = 16, cousinFirstName = "Victoire", cousinLastName = "Weasley", personIDFK = 7 },
                new cousin { cousinID = 17, cousinFirstName = "Dominique", cousinLastName = "Weasley", personIDFK = 7 },
                new cousin { cousinID = 18, cousinFirstName = "Louis", cousinLastName = "Weasley", personIDFK = 7 },
                new cousin { cousinID = 19, cousinFirstName = "Victoire", cousinLastName = "Weasley", personIDFK = 6 },
                new cousin { cousinID = 20, cousinFirstName = "Dominique", cousinLastName = "Weasley", personIDFK = 6 },
                new cousin { cousinID = 21, cousinFirstName = "Louis", cousinLastName = "Weasley", personIDFK = 6 },
                new cousin { cousinID = 22, cousinFirstName = "Victoire", cousinLastName = "Weasley", personIDFK = 5 },
                new cousin { cousinID = 23, cousinFirstName = "Dominique", cousinLastName = "Weasley", personIDFK = 5 },
                new cousin { cousinID = 24, cousinFirstName = "Louis", cousinLastName = "Weasley", personIDFK = 5 }
                );


           modelBuilder.Entity<address>().HasData(
                new address { addressID = 1, personIDFK = 1, city = "Godric's Hollow", country = "Great Britain", BirthDate = 1980 },
                new address { addressID = 2, personIDFK = 2, city = "", country = "Great Britain", BirthDate = 1981 },
                new address { addressID = 3, personIDFK = 3, city = "Godric's Hollow", country = "Great Britain", BirthDate = 1960, DethDate = 1981 },
                new address { addressID = 4, personIDFK = 4, city = "Godric's Hollow", country = "Great Britain", BirthDate = 1960, DethDate = 1981 },
                new address { addressID = 5, personIDFK = 5, city = "Godric's Hollow", country = "Great Britain" },
                new address { addressID = 6, personIDFK = 6, city = "Godric's Hollow", country = "Great Britain", BirthDate = 2006 },
                new address { addressID = 7, personIDFK = 7, city = "Godric's Hollow", country = "Great Britain", BirthDate = 1980 },
                new address { addressID = 8, personIDFK = 8, city = "", country = "Great Britain", BirthDate = 1958 },
                new address { addressID = 9, personIDFK = 9, city = "Godric's Hollow", country = "Great Britain", BirthDate = 1954 },
                new address { addressID = 10, personIDFK = 10, city = "", country = "Great Britain", BirthDate = 1980 },
                new address { addressID = 11, personIDFK = 11, city = "", country = "Great Britain", DethDate = 1979 },
                new address { addressID = 12, personIDFK = 12, city = "", country = "Great Britain", BirthDate = 1909, DethDate = 1978 },    
                new address { addressID = 13, personIDFK = 13, city = "", country = "Great Britain", BirthDate = 1951 },
                new address { addressID = 14, personIDFK = 14, city = "", country = "Great Britain", BirthDate = 1950 },
                new address { addressID = 15, personIDFK = 15, city = "",country = "Great Britain", BirthDate = 1980 },
                new address { addressID = 16, personIDFK = 16, city = "",country = "Great Britain", BirthDate = 1978 },
                new address { addressID = 17, personIDFK = 17, city = "",country = "Great Britain", BirthDate = 1978, DethDate = 1997 },
                new address { addressID = 18, personIDFK = 18, city = "",country = "Great Britain", BirthDate = 1976 },
                new address { addressID = 19, personIDFK = 19, city = "",country = "Great Britain", BirthDate = 1972 },
                new address { addressID = 20, personIDFK = 20, city = "",country = "Great Britain", BirthDate = 1970 }
                );

        }
    }
}
