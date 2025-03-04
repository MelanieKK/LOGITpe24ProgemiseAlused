print ("Kalkulator")

num1 = float(input("Lisa esimene number: "))
num2 = float(input("Lisa teine number: "))

print("Vali tehe:")
print("Liitmine, Lahutamine, Korrutamine, Jagamine")

tehe = input("Sisesta tehe: ")

if tehe == "Liitmine":
    print(num1 + num2)
elif tehe == "Lahutamine":
    print(num1 - num2)
elif tehe == "Korrutamine":
    print(num1 * num2)
elif tehe == "Jagamine":
    print(num1 / num2)
else:
    print("Vale sisend")

# Kalkulaatori lõpp