# hola
import tkinter as tk

def clear():
    entry1.delete(0, tk.END)
    entry2.delete(0, tk.END)

def f(number):
    f = (number * 9 / 5) + 32
    return f

def c(number):
    c = (number - 32) * 5.0 / 9.0
    return c

def fConvert():
    entry1.delete(0, tk.END)
    entry1.insert(0, f(float(entry2.get())))

def cConvert():
    entry2.delete(0, tk.END)
    entry2.insert(0, c(float(entry1.get())))


app = tk.Tk()
app.title("Temperature Converter")
label1 = tk.Label(app, text="Farenheit:")
label1.grid(row=0,column=0)
entry1 = tk.Entry(app)
entry1.grid(row=0,column=1)
btn1 = tk.Button(app,text="To Celcius", command=cConvert)
btn1.grid(row=0,column=2)
label2 = tk.Label(app,text="Celcius:")
label2.grid(row=1,column=0)
entry2 = tk.Entry(app)
entry2.grid(row=1,column=1)
btn2 = tk.Button(app,text="To Farenheit", command=fConvert)
btn2.grid(row=1,column=2)
btn2 = tk.Button(app,text="Clear", command=clear)
btn2.grid(row=2,column=1)


app.mainloop()
