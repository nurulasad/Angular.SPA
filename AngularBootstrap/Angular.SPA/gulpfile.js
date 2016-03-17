/// <binding />
// include plug-ins
var gulp = require('gulp');
var concat = require('gulp-concat');
var uglify = require('gulp-uglify');
var minifycss = require("gulp-minify-css");
var del = require('del');
var merge = require('merge-stream');


var config = {
    //Include all js files but exclude any min.js files

    jsMinified: [
        "bower_components/angular/angular.min.js",
        "bower_components/jquery/dist/jquery.min.js",
        "bower_components/jquery-ui/jquery-ui.min.js",

        "bower_components/angular-ui-router/release/angular-ui-router.min.js",
        "bower_components/angular-resource/angular-resource.min.js",
        "bower_components/angular-animate/angular-animate.min.js",

        
    ],

    jsRegular: [

        "angular/app.js",


       

    ],

  
    css: [

    ]
}

//build datestamp for cache busting
function guid() {
    function s4() {
        return Math.floor((1 + Math.random()) * 0x10000)
          .toString(16)
          .substring(1);
    }
    return s4() + s4() + '-' + s4() + '-' + s4() + '-' +
      s4() + '-' + s4() + s4() + s4();
}

//delete the output file(s)
gulp.task('clean', function () {
    //del is an async function and not a gulp plugin (just standard nodejs)
    //It returns a promise, so make sure you return that from this task function
    //  so gulp knows when the delete is complete
    return del(
        ['angular/combined-*.js',
         ,'Content/combined-*.css'
        ]);
});

// Combine and minify all files from the app folder
// This tasks depends on the clean task which means gulp will ensure that the 
// Clean task is completed before running the scripts task.
gulp.task('scripts', ['clean'], function () {

    var loading1 = gulp.src(config.jsMinified);

    var loading2 = gulp.src(config.jsRegular)
                   .pipe(uglify());

    
    return merge(loading1, loading2)
            .pipe(concat('combined-99.min.js'))
            .pipe(gulp.dest('angular/'));

});


gulp.task("minify-css", function () {
    return gulp.src(config.css)
            .pipe(minifycss())
            .pipe(concat("combined-77.min.css")) //" + guid() + "
            .pipe(gulp.dest('Content/'));
});


//Set a default tasks
gulp.task('default', ['scripts'], function () { });

gulp.task('watch', function () {
    return gulp.watch(
        [config.jsMinified, config.jsRegular, config.css],
        ['scripts', 'minify-css']
    );
});