const Task = require('../models/Task');

module.exports = {
	index: (req, res) => {

		Task.find().then( tasks => {//намери ми всички таскове и след това изпълни командата в скобите (тъй като е асинхронно)

			let openTasks = []; 		//създаваме масив с Open task
			let inProgressTasks = [];	//създаваме масив с in Progress task
			let finishedTasks = [];		//създаваме масив с finished task

			for (let i = 0; i <tasks.length; i++){
				let currentTask = tasks[i];

				if (currentTask.status === 'Open'){
					openTasks.push(currentTask);
				}else if (currentTask.status ==='In Progress'){
					inProgressTasks.push(currentTask);
				}else if (currentTask.status ==='Finished'){
					finishedTasks.push(currentTask);
				}
			}
                res.render('task/index', {			//казваме на view да ги покаже
                	'openTasks': openTasks,
					'inProgressTasks': inProgressTasks,
					'finishedTasks': finishedTasks
            });
        });
    },

	createGet: (req, res) => {
    	res.render('task/create'); //kazvame mu da pokaje view za create task
	},
	createPost: (req, res) => {
		let task = req.body; //suzdavame promenliva task
   		Task.create(task).then(task => { //suzdavame obekt Task, kojto sydyrva infoto ot task
        res.redirect("/");
})
	},
	editGet: (req, res) => {
		let id = req.params.id; // взимаме ид на таск
		Task.findById(id).then(task=>{

			res.render('task/edit',  task);
		});
	},
	editPost: (req, res) => {
        let id = req.params.id;
        let task = req.body;


		Task.findByIdAndUpdate(id,  task).then(task =>{
			"use strict";
			res.redirect('/');
		});
	}
};