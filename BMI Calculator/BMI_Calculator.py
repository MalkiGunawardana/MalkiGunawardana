from tkinter import *
import tkinter as tk
from tkinter import ttk
from PIL import Image, ImageTk

root=tk.Tk()
root.title("BMI Calculator")
root.iconbitmap('bmi.ico')
root.resizable(False,False)
root.configure(bg="#229727")

#find center and open window center
width,height_window=500,700
display_width=root.winfo_screenwidth()
display_height=root.winfo_screenheight()
left=int(display_width/2-width/2)
top=int(display_height/2-height_window/2)
root.geometry(f'{width}x{height_window}+{left}+{top}')

def bmi():
    h=float(Height.get())
    w=float(Weight.get())
    m=h/100
    bmi_val=round(float(w/m**2),1)
    label1.config(text=bmi_val)

    if bmi_val<=18.5:
        label2.config(text="Underweight",fg="#3498DB")
        label3.config(text="Your body is less than the normal \nrecommended weight.You need to eat more\n nutritious food with adequate exercises. ")
    elif (bmi_val>18.5)and(bmi_val<=22.9):
        label2.config(text="Normal weight",fg="#13CC1B")
        label3.config(text="Your weight is within the normal \nrecommended weight. Maintain your \nweight with adequate exercises.")
    elif (bmi_val>=23)and(bmi_val<=24.9):
        label2.config(text="Risk to overweight",fg="#C5F015")
        label3.config(text="Your weight is within the normal \nrecommended weight. Try to bring down it \nwith more exercises and correct dietary \npractices.") 
    elif (bmi_val>=25)and(bmi_val<=29.9):
        label2.config(text="Overweight",fg="#F08915")
        label3.config(text="Your weight is more than the normal \nrecommended weight. Bring down it with more\n exercises and correct dietary practices.")      
    else:
        label2.config(text="Obesity",fg="#F03315")
        label3.config(text="Your weight is very much higher than the \nnormal recommended weight and is a risk factor for\n many other diseases like diabetes and heart \ndiseases.Bring down it with more exercises, \ncorrect dietary practices and medical advices.")         


#top
top = PhotoImage(file="top.png")
top_image = Label(root, image=top, background="white",width='600',height='150')
top_image.place(x=-10,y=-10)


#bottom box
#Label(root, width=72,height=18,bg="white").pack(side=BOTTOM)
bottom_label=Label(root, width=72,height=18,bg="white")
bottom_label.pack(side=BOTTOM)

'''#two boxes
box=PhotoImage(file="box.png")
box_image=Label(root, image=box, background="white",width='150',height='150')
box_image.place(x=260,y=210)
box_image.place(x=20,y=200)'''

#two boxes
box=PhotoImage(file="box.png")
Label(root,image=box, width='152',height='152').place(x=40,y=200)
Label(root,image=box, width='152',height='152').place(x=300,y=200)

#height weight label
h_label=Label(root,background="white",text="Height (cm)",width=19,fg="black",bd=0,font="arial 10 bold",justify=CENTER)
h_label.place(x=40,y=210)

w_label=Label(root,background="white",text="Weight (kg)",width=19,fg="black",bd=0,font="arial 10 bold",justify=CENTER)
w_label.place(x=300,y=210)

#scale
scale=PhotoImage(file="scl.png")
Label(root,image=scale, width='50',height='250',background='white').place(x=20,y=440)

#slider1

current_value=tk.DoubleVar()

def get_current_val():
    return '{: .2f}'.format(current_value.get())
def slider_changed(event):
    Height.set(get_current_val())

    size=int(float(get_current_val()))
    img=(Image.open("man.png"))
    resized_image=img.resize((50,10+size))
    photo2=ImageTk.PhotoImage(resized_image)
    person_img.config(image=photo2)
    person_img.place(x=60,y=670-size)
    person_img.image=photo2


style=ttk.Style()
style.configure("TScale",background="white")
slider=ttk.Scale(root,from_=0,to=220,orient="horizontal",style="TScale",command=slider_changed,variable=current_value)
slider.place(x=70,y=320)

#slider2


current_value2=tk.DoubleVar()

def get_current_val2():
    return '{: .2f}'.format(current_value2.get())
def slider_changed2(event):
    Weight.set(get_current_val2())



style2=ttk.Style()
style2.configure("TScale",background="white")
slider2=ttk.Scale(root,from_=0,to=200,orient="horizontal",style="TScale",command=slider_changed2,variable=current_value2)
slider2.place(x=330,y=320)


#weight and height
Height=StringVar()
Weight=StringVar()

height=Entry(root,textvariable=Height,font='arial 30',bg="white",fg="black",bd=0,width='7',justify=CENTER)
height.place(x=40,y=250)
Height.set(get_current_val())

weight=Entry(root,textvariable=Weight,font='arial 30',bg="white",fg="black",bd=0,width='7',justify=CENTER)
weight.place(x=300,y=250)
Weight.set(get_current_val2())

#man image
person_img=Label(root,bg="white")
person_img.place(x=70,y=530)

#button
Button(root,text="Calculate",width=15,height=2,font="arial 10 bold",bg="#229727",fg="white",bd=0,command=bmi).place(x=340,y=640)

label1=Label(root,font="arial 30 bold",bg="white",fg="black")
label1.place(x=150,y=630)

label2=Label(root,font="arial 20 bold",bg="white",fg="black")
label2.place(x=220,y=450)

label3=Label(root,font="arial 10 bold",bg="white",fg="black")
label3.place(x=120,y=510)




root.mainloop()
