
from flask import *
import os , json
from datetime import datetime

USERS = "users"
LOGS = "logs"
DATA_DIR = "data"

import random

def create_random_number():
	return random.randint(10000, 99999)

def get_date():
	date = datetime.now()
	return create_random_number() + "_" + f"{date.hour}{date.minute}{date.second}{date.day}{date.month}{date.year}"
app = Flask ("ViX Server Version 1")


@app.route('/submit_report', methods=['POST'])
def submit_report():
	try:
		if not os.path.exists(DATA_DIR):
			os.path.os.mkdir(DATA_DIR)

		data = request.json
		vid = get_date()
		contact = data["contact"]
		report = data["report"]
		file = os.path.join(DATA_DIR ,vid)		
		with open (file , "w") as fp:
			json.dump(data , fp)

		return vid

	except Exception as err:
		print (err)
	return ""

@app.route('/', methods=['GET'])
def index():
	try:
		return open ("index.html" , "rb").read()
	except Exception as err:
		print (err + "nknvfnvf")
	return ""

@app.route('/Whistleblower', methods=['GET'])
def Whistleblower():
	try:
		return open ("Whistleblower.html" , "rb").read()
	except Exception as err:
		print (err + "nknvfnvf")
	return ""


def create_dir(_dir):
	try:
		if not os.path.exists(_dir):
			os.mkdir(_dir)
		return True
	except:
		pass
	return False
@app.route ("/register" , methods=['GET', 'POST'])
def register():
	try:
		if request.method == 'GET':
			return open("register.html", "rb").read()
		elif request.method == 'POST':
			if not create_dir(USERS):
				return json.dumps({"status": "error"})
			data = request.get_json()
			uid = get_date()
			with open(USERS + "/" + uid, "w") as fp:
				fp.write(json.dumps({"username":data["username"] ,"uid": uid, "password": data["password"],"rid": data["rid"], "date": data["date"]}))
				return json.dumps({"status": "success", "text": "", "uid": uid})
	except Exception as err:
		print (err)
		return json.dumps({"status": "error", "text": str (err)})

@app.route ("/request_protect" , methods=['GET', 'POST'])
def request_protect():
	try:
		if request.method == 'GET':
			return open("request_protect_details.html", "rb").read()
		elif request.method == 'POST':
			data = request.get_json()
			return "لقد تم ارسال طلبك"
	except Exception as err:
		print (err)
		return json.dumps({"status": "error", "text": str (err)})
		


@app.route ("/bot" , methods=['GET', 'POST'])
def bot():
	try:
		if request.method == 'GET':
			return open("auto.html", "rb").read()

		elif request.method == 'POST':
			data = request.get_json()
			message = data["message"]
			with open ("money.txt" , "r" , encoding="UTF-8") as fp:
				lines = fp.readlines()
				for line in lines:
					if message in line:
						return jsonify({"response":str(line)})
		return ""
	except Exception as err:
		print (err)
		return ""

@app.route ("/login")
def login():
	try:
		return open ("login.html" , "rb").read()
		data = json.loads(request.get_data().decode())
	except Exception as err:
		return json.dumps({
"status":"error","text":""
})

app.run(port=8888 , host = "0.0.0.0")