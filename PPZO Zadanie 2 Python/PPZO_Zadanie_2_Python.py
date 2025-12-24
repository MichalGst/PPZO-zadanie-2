class Pet:
    def __init__ (self,name,fun,hunger,energy):
        self.name = name
        self.fun = fun
        self.hunger = hunger
        self.energy = energy

class Food:
    def __init__ (self,nutrition):
        self.nutrition = nutrition

class Toy:
    def __init__ (self,fun, energyDrain):
        self.fun = fun
        self.energyDrain = energyDrain

class Status:
    def __init__ (self,energy,fun,hunger):
        self.energy = energy
        self.fun = fun
        self.hunger = hunger

    def statystyki(self):
        return f"Energia: " + str(self.energy) + "/100\n" + "Zabawa: " + str(self.fun) + "/100\n" + "Glod: " + str(self.hunger) + "/100\n"

start = 1
menu = 0

Dog = Pet("Azor",50,10,100)
Karma = Food(100)
Pilka = Toy(50,40)
ZdrowieAzor = Status(Dog.energy,Dog.fun,Dog.hunger)

print(ZdrowieAzor.statystyki())
print("1.Karmienie\n2.Zabawa\n3.Statystyki\n4.Wyjscie\n")

while start == 1:
    menu = input("Wybierz opcje: ")

    if menu == "1":
        ZdrowieAzor.hunger -= Karma.nutrition
        ZdrowieAzor.fun -= 10
        ZdrowieAzor.energy += 50
        print("Pies zjadl karme\n")

    elif menu == "2":
        if ZdrowieAzor.energy > 0:
            ZdrowieAzor.hunger += 20
            ZdrowieAzor.fun += Pilka.fun
            ZdrowieAzor.energy -= Pilka.energyDrain
            print("Pobawiles sie z psem pilka\n")
        else:
            print("Pies jest zbyt zmeczony.")
            ZdrowieAzor.hunger += 10


    elif menu == "3":
        if ZdrowieAzor.energy > 100:
            ZdrowieAzor.energy = 100
        elif ZdrowieAzor.energy < 0:
            ZdrowieAzor.energy = 0
        if ZdrowieAzor.fun > 100:
            ZdrowieAzor.fun = 100
        elif ZdrowieAzor.fun < 0:
            ZdrowieAzor.fun = 0
        if ZdrowieAzor.hunger < 0:
            ZdrowieAzor.hunger = 0
        print(ZdrowieAzor.statystyki())

    elif menu == "4":
        start = 0

    if ZdrowieAzor.hunger >= 100:
        print("Pies zdechl z glodu :(")
        start = 0


    