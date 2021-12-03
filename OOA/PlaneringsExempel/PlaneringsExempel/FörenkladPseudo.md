# Utförlig pseudo
// Framtida problem:
//      Tal kan vara bokstäver
//      Tal kan vara tomma
//      Flytta resultat till tal 1

// Loop
//		Kalla metod för talInput och lagra i tal1

// Loop
//		Kalla metod för operator och lagra i op

//		Fråga : tal 2
//		Kalla metod för talInput och lagra i tal2

// Hantera operator och tal
// Anropa metod för Switch av operator

// lagra resultat i variabel res
// visa tal1 operator tal2 = res

// tal1 = res
// hoppa till fråga om operator

// starta om

TalInput metod
	loop 
		Fråga : tal
		Måste vara ett tal, annars fråga igen
	Om tom, avsluta program (Environment.Exit(0))
	returnera tal omvandlat

OperatorInput metod
loop
	Fråga : operator
	Måste vara +-*/, annars fråga igen
	Om tom, avsluta program
	returnera op

WitchOperator metod
// Switch
//    operator + : res = tal1 + tal2
//    operator - : res = tal1 - tal2
//    operator * : res = tal1 * tal2
//    operator 7 : res = tal1 / tal2